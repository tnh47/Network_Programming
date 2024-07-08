namespace Lab05
{
    partial class SendEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bodyText = new System.Windows.Forms.Label();
            this.senderGmailBox = new System.Windows.Forms.TextBox();
            this.receiverBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.bodyBox = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.isHTML = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.browserBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // bodyText
            // 
            this.bodyText.AutoSize = true;
            this.bodyText.Location = new System.Drawing.Point(33, 168);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(39, 16);
            this.bodyText.TabIndex = 4;
            this.bodyText.Text = "Body";
            // 
            // senderGmailBox
            // 
            this.senderGmailBox.Location = new System.Drawing.Point(107, 29);
            this.senderGmailBox.Name = "senderGmailBox";
            this.senderGmailBox.Size = new System.Drawing.Size(490, 22);
            this.senderGmailBox.TabIndex = 5;
            // 
            // receiverBox
            // 
            this.receiverBox.Location = new System.Drawing.Point(107, 79);
            this.receiverBox.Name = "receiverBox";
            this.receiverBox.Size = new System.Drawing.Size(490, 22);
            this.receiverBox.TabIndex = 6;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(107, 123);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(490, 22);
            this.subjectBox.TabIndex = 8;
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(107, 211);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(490, 178);
            this.bodyBox.TabIndex = 9;
            this.bodyBox.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(532, 533);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(88, 34);
            this.send.TabIndex = 10;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // isHTML
            // 
            this.isHTML.AutoSize = true;
            this.isHTML.Location = new System.Drawing.Point(107, 168);
            this.isHTML.Name = "isHTML";
            this.isHTML.Size = new System.Drawing.Size(66, 20);
            this.isHTML.TabIndex = 11;
            this.isHTML.Text = "HTML";
            this.isHTML.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Attachment:";
            // 
            // browserBtn
            // 
            this.browserBtn.Location = new System.Drawing.Point(532, 416);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(88, 34);
            this.browserBtn.TabIndex = 14;
            this.browserBtn.Text = "Browser";
            this.browserBtn.UseVisualStyleBackColor = true;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(107, 416);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 92);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 608);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.browserBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isHTML);
            this.Controls.Add(this.send);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.receiverBox);
            this.Controls.Add(this.senderGmailBox);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bodyText;
        public System.Windows.Forms.TextBox senderGmailBox;
        public System.Windows.Forms.TextBox receiverBox;
        public System.Windows.Forms.TextBox subjectBox;
        public System.Windows.Forms.RichTextBox bodyBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.CheckBox isHTML;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browserBtn;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}