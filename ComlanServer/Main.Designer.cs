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
            label5 = new Label();
            label9 = new Label();
            labelMessageSend = new Label();
            buttonMinimize = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Image = Properties.Resources.icons8_start_24;
            buttonStart.Location = new Point(22, 206);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(30, 30);
            buttonStart.TabIndex = 0;
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.FlatAppearance.BorderSize = 0;
            buttonStop.FlatStyle = FlatStyle.Flat;
            buttonStop.Image = Properties.Resources.icons8_stop_24;
            buttonStop.Location = new Point(101, 206);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(30, 30);
            buttonStop.TabIndex = 1;
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += ButtonStop_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(30, 53);
            label.Name = "label";
            label.Size = new Size(105, 14);
            label.TabIndex = 2;
            label.Text = "Server State :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 78);
            label1.Name = "label1";
            label1.Size = new Size(84, 14);
            label1.TabIndex = 3;
            label1.Text = "Server IP :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 103);
            label2.Name = "label2";
            label2.Size = new Size(98, 14);
            label2.TabIndex = 4;
            label2.Text = "Server Port :";
            // 
            // labelServerState
            // 
            labelServerState.AutoSize = true;
            labelServerState.Location = new Point(169, 53);
            labelServerState.Name = "labelServerState";
            labelServerState.Size = new Size(98, 14);
            labelServerState.TabIndex = 5;
            labelServerState.Text = "[ServerState]";
            // 
            // labelServerIP
            // 
            labelServerIP.AutoSize = true;
            labelServerIP.Location = new Point(169, 78);
            labelServerIP.Name = "labelServerIP";
            labelServerIP.Size = new Size(112, 14);
            labelServerIP.TabIndex = 6;
            labelServerIP.Text = "255.255.255.255";
            // 
            // labelServerPort
            // 
            labelServerPort.AutoSize = true;
            labelServerPort.Location = new Point(169, 103);
            labelServerPort.Name = "labelServerPort";
            labelServerPort.Size = new Size(49, 14);
            labelServerPort.TabIndex = 7;
            labelServerPort.Text = "65 535";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 57);
            label6.Name = "label6";
            label6.Size = new Size(280, 14);
            label6.TabIndex = 8;
            label6.Text = "_______________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 82);
            label7.Name = "label7";
            label7.Size = new Size(280, 14);
            label7.TabIndex = 9;
            label7.Text = "_______________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 107);
            label8.Name = "label8";
            label8.Size = new Size(280, 14);
            label8.TabIndex = 10;
            label8.Text = "_______________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 128);
            label3.Name = "label3";
            label3.Size = new Size(126, 14);
            label3.TabIndex = 11;
            label3.Text = "Users connected :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 132);
            label4.Name = "label4";
            label4.Size = new Size(280, 14);
            label4.TabIndex = 12;
            label4.Text = "_______________________________________";
            // 
            // labelUserConnected
            // 
            labelUserConnected.AutoSize = true;
            labelUserConnected.Location = new Point(169, 128);
            labelUserConnected.Name = "labelUserConnected";
            labelUserConnected.Size = new Size(14, 14);
            labelUserConnected.TabIndex = 13;
            labelUserConnected.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 9);
            label5.Name = "label5";
            label5.Size = new Size(160, 22);
            label5.TabIndex = 14;
            label5.Text = "ComLan - Server";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 153);
            label9.Name = "label9";
            label9.Size = new Size(105, 14);
            label9.TabIndex = 15;
            label9.Text = "Message send :";
            // 
            // labelMessageSend
            // 
            labelMessageSend.AutoSize = true;
            labelMessageSend.Location = new Point(169, 153);
            labelMessageSend.Name = "labelMessageSend";
            labelMessageSend.Size = new Size(14, 14);
            labelMessageSend.TabIndex = 16;
            labelMessageSend.Text = "0";
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Image = Properties.Resources.icons8_minimize_window_24;
            buttonMinimize.Location = new Point(180, 206);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(30, 30);
            buttonMinimize.TabIndex = 17;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = Properties.Resources.icons8_close_window_24;
            buttonClose.Location = new Point(259, 206);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(30, 30);
            buttonClose.TabIndex = 18;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(311, 239);
            Controls.Add(buttonClose);
            Controls.Add(buttonMinimize);
            Controls.Add(labelMessageSend);
            Controls.Add(label9);
            Controls.Add(label5);
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
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
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
        private Label label5;
        private Label label9;
        private Label labelMessageSend;
        private Button buttonMinimize;
        private Button buttonClose;
    }
}
