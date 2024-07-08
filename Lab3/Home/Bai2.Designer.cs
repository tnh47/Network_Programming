namespace Home
{
    partial class Bai2
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
            this.listView = new System.Windows.Forms.ListView();
            this.listen = new System.Windows.Forms.Button();
            this.button1_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 129);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 309);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // listen
            // 
            this.listen.BackColor = System.Drawing.Color.White;
            this.listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.Location = new System.Drawing.Point(528, 43);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(96, 45);
            this.listen.TabIndex = 1;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // button1_exit
            // 
            this.button1_exit.BackColor = System.Drawing.Color.White;
            this.button1_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_exit.Location = new System.Drawing.Point(661, 43);
            this.button1_exit.Name = "button1_exit";
            this.button1_exit.Size = new System.Drawing.Size(93, 45);
            this.button1_exit.TabIndex = 2;
            this.button1_exit.Text = "Exit";
            this.button1_exit.UseVisualStyleBackColor = false;
            this.button1_exit.Click += new System.EventHandler(this.button1_exit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_exit);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.listView);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.Button button1_exit;
    }
}