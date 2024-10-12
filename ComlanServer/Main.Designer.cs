namespace ComlanServer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart = new Button();
            buttonStop = new Button();
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            labelServerState = new Label();
            labelServerIP = new Label();
            labelServerPort = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelUserConnected = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 126);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(68, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(165, 126);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(68, 23);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += ButtonStop_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 11);
            label.Name = "label";
            label.Size = new Size(74, 15);
            label.TabIndex = 2;
            label.Text = "Server State :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Server IP :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Server Port :";
            // 
            // labelServerState
            // 
            labelServerState.AutoSize = true;
            labelServerState.Location = new Point(151, 11);
            labelServerState.Name = "labelServerState";
            labelServerState.Size = new Size(73, 15);
            labelServerState.TabIndex = 5;
            labelServerState.Text = "[ServerState]";
            // 
            // labelServerIP
            // 
            labelServerIP.AutoSize = true;
            labelServerIP.Location = new Point(151, 38);
            labelServerIP.Name = "labelServerIP";
            labelServerIP.Size = new Size(88, 15);
            labelServerIP.TabIndex = 6;
            labelServerIP.Text = "255.255.255.255";
            // 
            // labelServerPort
            // 
            labelServerPort.AutoSize = true;
            labelServerPort.Location = new Point(151, 65);
            labelServerPort.Name = "labelServerPort";
            labelServerPort.Size = new Size(40, 15);
            labelServerPort.TabIndex = 7;
            labelServerPort.Text = "65 535";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 15);
            label6.Name = "label6";
            label6.Size = new Size(202, 15);
            label6.TabIndex = 8;
            label6.Text = "_______________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 42);
            label7.Name = "label7";
            label7.Size = new Size(202, 15);
            label7.TabIndex = 9;
            label7.Text = "_______________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 69);
            label8.Name = "label8";
            label8.Size = new Size(202, 15);
            label8.TabIndex = 10;
            label8.Text = "_______________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 11;
            label3.Text = "Users connected :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 96);
            label4.Name = "label4";
            label4.Size = new Size(202, 15);
            label4.TabIndex = 12;
            label4.Text = "_______________________________________";
            // 
            // labelUserConnected
            // 
            labelUserConnected.AutoSize = true;
            labelUserConnected.Location = new Point(151, 92);
            labelUserConnected.Name = "labelUserConnected";
            labelUserConnected.Size = new Size(14, 15);
            labelUserConnected.TabIndex = 13;
            labelUserConnected.Text = "X";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(245, 161);
            ControlBox = false;
            Controls.Add(labelUserConnected);
            Controls.Add(label3);
            Controls.Add(labelServerPort);
            Controls.Add(labelServerIP);
            Controls.Add(labelServerState);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Comlan Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Label label;
        private Label label1;
        private Label label2;
        private Label labelServerState;
        private Label labelServerIP;
        private Label labelServerPort;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label labelUserConnected;
    }
}
