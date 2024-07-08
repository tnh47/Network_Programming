namespace Lab05
{
    partial class ViewEmail
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bodyText = new System.Windows.Forms.RichTextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.attachmentsListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.replyBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(113, 18);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 16);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(113, 51);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(44, 16);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subject";
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(36, 124);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(743, 263);
            this.bodyText.TabIndex = 6;
            this.bodyText.Text = "";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(113, 94);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(44, 16);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "label7";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(36, 124);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(743, 263);
            this.webBrowser1.TabIndex = 9;
            // 
            // attachmentsListView
            // 
            this.attachmentsListView.HideSelection = false;
            this.attachmentsListView.Location = new System.Drawing.Point(36, 424);
            this.attachmentsListView.Name = "attachmentsListView";
            this.attachmentsListView.Size = new System.Drawing.Size(743, 97);
            this.attachmentsListView.TabIndex = 10;
            this.attachmentsListView.UseCompatibleStateImageBehavior = false;
            this.attachmentsListView.ItemActivate += new System.EventHandler(this.attachmentsListView_ItemActivate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Attachments";
            // 
            // replyBtn
            // 
            this.replyBtn.Location = new System.Drawing.Point(552, 18);
            this.replyBtn.Name = "replyBtn";
            this.replyBtn.Size = new System.Drawing.Size(104, 45);
            this.replyBtn.TabIndex = 12;
            this.replyBtn.Text = "Reply";
            this.replyBtn.UseVisualStyleBackColor = true;
            this.replyBtn.Click += new System.EventHandler(this.replyBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(675, 18);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(104, 45);
            this.forwardBtn.TabIndex = 13;
            this.forwardBtn.Text = "Foward";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // ViewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.replyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attachmentsListView);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.label1);
            this.Name = "ViewEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox bodyText;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListView attachmentsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button replyBtn;
        private System.Windows.Forms.Button forwardBtn;
    }
}