using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Flight_Controller_2
{

    public partial class RemoteFlightController : Form
    {
        public RemoteFlightController()
        {
            InitializeComponent();
        }

        struct ControlsUpdate
        {
            public ControlsUpdate(int throttle, int elevatorPitch)
            {
                Throttle = throttle;
                ElevatorPitch = elevatorPitch;
            }
            public double Throttle;
            public double ElevatorPitch;
        }

        struct TelemetryUpdate
        {
            public TelemetryUpdate(int altitude, int speed, int pitch, int verticalSpeed, int throttle, int elevatorPitch, int warnningCode)
            {
                Altitude = altitude;
                Speed = speed;
                Pitch = pitch;
                VerticalSpeed = verticalSpeed;

                Throttle = throttle;
                ElevatorPitch = elevatorPitch;

                WarningCode = warnningCode;
            }
            public double Altitude;      //Altitude in ft.
            public double Speed;         //Plane's speed in Knts.
            public double Pitch;         //Plane's pitch in degrees relative to horizon. Positive is planes pointing upwards, negative plane points downwards;
            public double VerticalSpeed; //Plane's vertical speed in Feet per minute.

            public double Throttle;      //Current throttle setting as a percentage (i.e. 0% no throttle, 100% full throttle).
            public double ElevatorPitch; //Current Elevator Pitch in degrees. Positive creates upwards lift, negative downwards.

            public int WarningCode;      //Warning code: 0 - No Warnings; 1 -  Too Low (less than 1000ft); 2 - Stall.
        }

        private String response = String.Empty;

        ControlsUpdate controlValues = new ControlsUpdate(30, 2);
        TelemetryUpdate telementryValues = new TelemetryUpdate(5000, 300, 0, 0, 30, 2, 0);

        private void throttle_bar_Scroll(object sender, EventArgs e)
        {
            controlValues.Throttle = throttle_bar.Value;
        }

        private void elevator_bar_Scroll(object sender, EventArgs e)
        {
            controlValues.ElevatorPitch = elevator_bar.Value / 10.0;
        }

        private void warning()
        {
            if (telementryValues.WarningCode == 0)
            {
                warning_textBox.Invoke(new Action(() => warning_textBox.ForeColor = Color.Green));
                warning_textBox.Invoke(new Action(() => warning_textBox.Text = "No Warning"));
            }
            else if (telementryValues.WarningCode == 1)
            {
                warning_textBox.Invoke(new Action(() => warning_textBox.ForeColor = Color.Red));
                warning_textBox.Invoke(new Action(() => warning_textBox.Text = "Too Low"));
            }
            else if (telementryValues.WarningCode == 2)
            {
                warning_textBox.Invoke(new Action(() => warning_textBox.ForeColor = Color.Red));
                warning_textBox.Invoke(new Action(() => warning_textBox.Text = "Stall"));
            }
        }
        
        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress remoteIP = IPAddress.Parse(ip_textBox.Text);
                IPEndPoint remoteEndPoint = new IPEndPoint(remoteIP, Convert.ToInt32(port_textBox.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                client.Connect(remoteEndPoint);

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    while(true)
                    {
                        runClient(remoteEndPoint, client);  //Here is a new thread
                        Thread.Sleep(100);
                    }
                }).Start();

                connect_button.Enabled = false;
                ip_textBox.Enabled = false;
                port_textBox.Enabled = false;
                connection_textBox.ForeColor = Color.Green;
                connection_textBox.Text = "Connected to " + client.RemoteEndPoint.ToString();
                Size size = TextRenderer.MeasureText(connection_textBox.Text, connection_textBox.Font);
                connection_textBox.Width = size.Width;
            }
            catch
            {
                MessageBox.Show("Couldn't Connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void runClient(IPEndPoint remoteEndPoint, Socket client)
        {
            try
            {
                //Send control updates to plane
                Send(client, JsonConvert.SerializeObject(controlValues));

                // Receive the response from the remote device.  
                Receive(client);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Receive(Socket client)
        {
            try
            {
                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.  
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket   
                // from the asynchronous state object.  
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.  
                client.EndReceive(ar);

                response = Encoding.ASCII.GetString(state.buffer, 0, state.buffer.Length);        //convertion from byte to string
                telementryValues = JsonConvert.DeserializeObject<TelemetryUpdate>(response);  //json data is tranformed into struct

                dataGridView1.Rows[0].Cells[0].Value = telementryValues.Throttle;
                dataGridView1.Rows[0].Cells[1].Value = telementryValues.ElevatorPitch;
                dataGridView2.Rows[0].Cells[0].Value = Math.Round(telementryValues.Altitude, 1);
                dataGridView2.Rows[0].Cells[1].Value = Math.Round(telementryValues.Pitch, 3);
                dataGridView3.Rows[0].Cells[0].Value = Math.Round(telementryValues.Speed, 1);
                dataGridView3.Rows[0].Cells[1].Value = Math.Round(telementryValues.VerticalSpeed, 1);
                warning();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                client.EndSend(ar);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }

    public class StateObject
    {
        // Client socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 256;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
    }
}
