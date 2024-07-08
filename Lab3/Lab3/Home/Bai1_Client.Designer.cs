namespace Home
{
    partial class Bai1_Client
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textHostIP = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.HostIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(563, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(49, 385);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 40);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textMessage
            // 
            this.textMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMessage.Location = new System.Drawing.Point(49, 152);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(614, 205);
            this.textMessage.TabIndex = 21;
            // 
            // textPort
            // 
            this.textPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPort.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPort.Location = new System.Drawing.Point(563, 58);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 34);
            this.textPort.TabIndex = 20;
            // 
            // textHostIP
            // 
            this.textHostIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textHostIP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHostIP.Location = new System.Drawing.Point(49, 58);
            this.textHostIP.Name = "textHostIP";
            this.textHostIP.Size = new System.Drawing.Size(289, 34);
            this.textHostIP.TabIndex = 19;
            // 
            // Message
            // 
            this.Message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(44, 111);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(90, 26);
            this.Message.TabIndex = 18;
            this.Message.Text = "Message";
            // 
            // Port
            // 
            this.Port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(558, 15);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(51, 26);
            this.Port.TabIndex = 17;
            this.Port.Text = "Port";
            // 
            // HostIP
            // 
            this.HostIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HostIP.AutoSize = true;
            this.HostIP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostIP.Location = new System.Drawing.Point(44, 15);
            this.HostIP.Name = "HostIP";
            this.HostIP.Size = new System.Drawing.Size(154, 26);
            this.HostIP.TabIndex = 16;
            this.HostIP.Text = "IP Remote host";
            // 
            // Bai1_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHostIP);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.HostIP);
            this.Name = "Bai1_Client";
            this.Text = "Bai1_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textHostIP;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label HostIP;
    }
}