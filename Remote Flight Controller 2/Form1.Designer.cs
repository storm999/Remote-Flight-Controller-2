namespace Remote_Flight_Controller_2
{
    partial class RemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteFlightController));
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.warning_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Throttle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connect_button = new System.Windows.Forms.Button();
            this.elevator_bar = new System.Windows.Forms.TrackBar();
            this.throttle_bar = new System.Windows.Forms.TrackBar();
            this.ip_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.connection_textBox = new System.Windows.Forms.TextBox();
            this.connection_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttle_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ip_textBox
            // 
            this.ip_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip_textBox.Location = new System.Drawing.Point(12, 29);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(100, 23);
            this.ip_textBox.TabIndex = 0;
            this.ip_textBox.Text = "77.109.163.250";
            // 
            // port_textBox
            // 
            this.port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.port_textBox.Location = new System.Drawing.Point(143, 29);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(36, 23);
            this.port_textBox.TabIndex = 1;
            this.port_textBox.Text = "9999";
            // 
            // warning_textBox
            // 
            this.warning_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warning_textBox.BackColor = System.Drawing.Color.White;
            this.warning_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warning_textBox.ForeColor = System.Drawing.Color.Green;
            this.warning_textBox.Location = new System.Drawing.Point(249, 107);
            this.warning_textBox.Name = "warning_textBox";
            this.warning_textBox.Size = new System.Drawing.Size(146, 35);
            this.warning_textBox.TabIndex = 2;
            this.warning_textBox.Text = "No Warning";
            this.warning_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Throttle,
            this.ElevatorPitch});
            this.dataGridView1.Location = new System.Drawing.Point(375, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 55);
            this.dataGridView1.TabIndex = 3;
            // 
            // Throttle
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Throttle.DefaultCellStyle = dataGridViewCellStyle2;
            this.Throttle.HeaderText = "Throttle";
            this.Throttle.Name = "Throttle";
            // 
            // ElevatorPitch
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ElevatorPitch.DefaultCellStyle = dataGridViewCellStyle3;
            this.ElevatorPitch.HeaderText = "Elevator Pitch";
            this.ElevatorPitch.Name = "ElevatorPitch";
            // 
            // connect_button
            // 
            this.connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connect_button.Location = new System.Drawing.Point(228, 13);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 31);
            this.connect_button.TabIndex = 4;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // elevator_bar
            // 
            this.elevator_bar.BackColor = System.Drawing.Color.White;
            this.elevator_bar.LargeChange = 1;
            this.elevator_bar.Location = new System.Drawing.Point(81, 192);
            this.elevator_bar.Maximum = 50;
            this.elevator_bar.Minimum = -50;
            this.elevator_bar.Name = "elevator_bar";
            this.elevator_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.elevator_bar.Size = new System.Drawing.Size(45, 198);
            this.elevator_bar.TabIndex = 6;
            this.elevator_bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.elevator_bar.Scroll += new System.EventHandler(this.elevator_bar_Scroll);
            // 
            // throttle_bar
            // 
            this.throttle_bar.BackColor = System.Drawing.Color.White;
            this.throttle_bar.Location = new System.Drawing.Point(293, 192);
            this.throttle_bar.Maximum = 100;
            this.throttle_bar.Name = "throttle_bar";
            this.throttle_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.throttle_bar.Size = new System.Drawing.Size(45, 198);
            this.throttle_bar.TabIndex = 7;
            this.throttle_bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.throttle_bar.Scroll += new System.EventHandler(this.throttle_bar_Scroll);
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip_label.Location = new System.Drawing.Point(14, 9);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(75, 17);
            this.ip_label.TabIndex = 8;
            this.ip_label.Text = "Ip Address";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.port_label.Location = new System.Drawing.Point(145, 9);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(34, 17);
            this.port_label.TabIndex = 9;
            this.port_label.Text = "Port";
            // 
            // connection_textBox
            // 
            this.connection_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connection_textBox.ForeColor = System.Drawing.Color.Chocolate;
            this.connection_textBox.Location = new System.Drawing.Point(345, 29);
            this.connection_textBox.Multiline = true;
            this.connection_textBox.Name = "connection_textBox";
            this.connection_textBox.Size = new System.Drawing.Size(94, 23);
            this.connection_textBox.TabIndex = 10;
            this.connection_textBox.Text = "Disconnected";
            // 
            // connection_label
            // 
            this.connection_label.AutoSize = true;
            this.connection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connection_label.Location = new System.Drawing.Point(346, 9);
            this.connection_label.Name = "connection_label";
            this.connection_label.Size = new System.Drawing.Size(123, 17);
            this.connection_label.TabIndex = 11;
            this.connection_label.Text = "Connection Status";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(375, 262);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(260, 55);
            this.dataGridView2.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Altitude";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "Pitch Angle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView3.Location = new System.Drawing.Point(375, 335);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(260, 55);
            this.dataGridView3.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Air Speed";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Vertical Speed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // RemoteFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Remote_Flight_Controller_2.Properties.Resources.cockpit2;
            this.ClientSize = new System.Drawing.Size(647, 421);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.connection_label);
            this.Controls.Add(this.connection_textBox);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.throttle_bar);
            this.Controls.Add(this.elevator_bar);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.warning_textBox);
            this.Controls.Add(this.port_textBox);
            this.Controls.Add(this.ip_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteFlightController";
            this.Text = "Remote Flight Controller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttle_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TrackBar elevator_bar;
        private System.Windows.Forms.TrackBar throttle_bar;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.TextBox connection_textBox;
        private System.Windows.Forms.Label connection_label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Throttle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.TextBox warning_textBox;
    }
}

