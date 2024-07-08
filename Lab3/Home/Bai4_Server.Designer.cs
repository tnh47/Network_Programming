namespace Home
{
    partial class Bai4_Sever
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
            this.rtb_mess = new System.Windows.Forms.RichTextBox();
            this.btn_listen = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_mess
            // 
            this.rtb_mess.Location = new System.Drawing.Point(43, 96);
            this.rtb_mess.Name = "rtb_mess";
            this.rtb_mess.ReadOnly = true;
            this.rtb_mess.Size = new System.Drawing.Size(675, 317);
            this.rtb_mess.TabIndex = 0;
            this.rtb_mess.Text = "";
            // 
            // btn_listen
            // 
            this.btn_listen.BackColor = System.Drawing.Color.White;
            this.btn_listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listen.Location = new System.Drawing.Point(464, 36);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(121, 39);
            this.btn_listen.TabIndex = 1;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = false;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(624, 36);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 39);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Bai4_Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.rtb_mess);
            this.Name = "Bai4_Sever";
            this.Text = "Bai4_Sever";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_mess;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.Button btn_exit;
    }
}