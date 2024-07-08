namespace Lab06
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNum = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerCnt = new System.Windows.Forms.Label();
            this.range = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAutoPlaySingleTurn = new System.Windows.Forms.Button();
            this.btnAutoplayWholeGame = new System.Windows.Forms.Button();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.answer = new Guna.UI2.WinForms.Guna2TextBox();
            this.ansNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.conversation = new System.Windows.Forms.RichTextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnReady = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.message = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Câu trả lời của bạn:";
            // 
            // playerNum
            // 
            this.playerNum.BackColor = System.Drawing.SystemColors.Control;
            this.playerNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNum.Location = new System.Drawing.Point(0, 0);
            this.playerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(858, 32);
            this.playerNum.TabIndex = 7;
            this.playerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.timerCnt);
            this.panel1.Controls.Add(this.range);
            this.panel1.Controls.Add(this.btnAutoPlaySingleTurn);
            this.panel1.Controls.Add(this.btnAutoplayWholeGame);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 134);
            this.panel1.TabIndex = 17;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 44);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(261, 37);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Thời gian còn lại:";
            // 
            // timerCnt
            // 
            this.timerCnt.Location = new System.Drawing.Point(269, 44);
            this.timerCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerCnt.Name = "timerCnt";
            this.timerCnt.Size = new System.Drawing.Size(40, 37);
            this.timerCnt.TabIndex = 19;
            this.timerCnt.Text = "X";
            this.timerCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // range
            // 
            this.range.AutoSize = false;
            this.range.BackColor = System.Drawing.Color.Transparent;
            this.range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range.Location = new System.Drawing.Point(387, 4);
            this.range.Margin = new System.Windows.Forms.Padding(4);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(168, 40);
            this.range.TabIndex = 23;
            this.range.Text = "range";
            // 
            // btnAutoPlaySingleTurn
            // 
            this.btnAutoPlaySingleTurn.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoPlaySingleTurn.Enabled = false;
            this.btnAutoPlaySingleTurn.FlatAppearance.BorderSize = 0;
            this.btnAutoPlaySingleTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPlaySingleTurn.ForeColor = System.Drawing.Color.Black;
            this.btnAutoPlaySingleTurn.Location = new System.Drawing.Point(653, 69);
            this.btnAutoPlaySingleTurn.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoPlaySingleTurn.Name = "btnAutoPlaySingleTurn";
            this.btnAutoPlaySingleTurn.Size = new System.Drawing.Size(156, 57);
            this.btnAutoPlaySingleTurn.TabIndex = 9;
            this.btnAutoPlaySingleTurn.TabStop = false;
            this.btnAutoPlaySingleTurn.Text = "Don\'t have answer\r\nAuto select answer";
            this.btnAutoPlaySingleTurn.UseVisualStyleBackColor = false;
            this.btnAutoPlaySingleTurn.Click += new System.EventHandler(this.autoTurn_Click);
            // 
            // btnAutoplayWholeGame
            // 
            this.btnAutoplayWholeGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoplayWholeGame.Enabled = false;
            this.btnAutoplayWholeGame.FlatAppearance.BorderSize = 0;
            this.btnAutoplayWholeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoplayWholeGame.ForeColor = System.Drawing.Color.Black;
            this.btnAutoplayWholeGame.Location = new System.Drawing.Point(653, 10);
            this.btnAutoplayWholeGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoplayWholeGame.Name = "btnAutoplayWholeGame";
            this.btnAutoplayWholeGame.Size = new System.Drawing.Size(156, 57);
            this.btnAutoplayWholeGame.TabIndex = 10;
            this.btnAutoplayWholeGame.TabStop = false;
            this.btnAutoplayWholeGame.Text = "Autoplay";
            this.btnAutoplayWholeGame.UseVisualStyleBackColor = false;
            this.btnAutoplayWholeGame.Click += new System.EventHandler(this.autoAllGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số cần đoán nằm trong khoảng:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(504, 86);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 37);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // answer
            // 
            this.answer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer.DefaultText = "";
            this.answer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answer.Location = new System.Drawing.Point(203, 86);
            this.answer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answer.Name = "answer";
            this.answer.PasswordChar = '\0';
            this.answer.PlaceholderText = "";
            this.answer.SelectedText = "";
            this.answer.Size = new System.Drawing.Size(267, 37);
            this.answer.TabIndex = 5;
            // 
            // ansNumber
            // 
            this.ansNumber.BackColor = System.Drawing.Color.Transparent;
            this.ansNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansNumber.Location = new System.Drawing.Point(16, 14);
            this.ansNumber.Margin = new System.Windows.Forms.Padding(4);
            this.ansNumber.Name = "ansNumber";
            this.ansNumber.Size = new System.Drawing.Size(3, 2);
            this.ansNumber.TabIndex = 22;
            this.ansNumber.Text = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.conversation);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnReady);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.ansNumber);
            this.panel2.Controls.Add(this.message);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 367);
            this.panel2.TabIndex = 18;
            // 
            // conversation
            // 
            this.conversation.Location = new System.Drawing.Point(16, 44);
            this.conversation.Margin = new System.Windows.Forms.Padding(4);
            this.conversation.Name = "conversation";
            this.conversation.Size = new System.Drawing.Size(615, 262);
            this.conversation.TabIndex = 25;
            this.conversation.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 10;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(653, 238);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 47);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReady
            // 
            this.btnReady.BorderRadius = 10;
            this.btnReady.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReady.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReady.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReady.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReady.ForeColor = System.Drawing.Color.White;
            this.btnReady.Location = new System.Drawing.Point(653, 169);
            this.btnReady.Margin = new System.Windows.Forms.Padding(4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(144, 47);
            this.btnReady.TabIndex = 23;
            this.btnReady.Text = "Ready";
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnSend
            // 
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.White;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::Lab06.Properties.Resources.Email_Send;
            this.btnSend.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSend.Location = new System.Drawing.Point(676, 315);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 34);
            this.btnSend.TabIndex = 8;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // message
            // 
            this.message.BorderRadius = 10;
            this.message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message.DefaultText = "";
            this.message.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.message.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message.Location = new System.Drawing.Point(16, 315);
            this.message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.message.Name = "message";
            this.message.PasswordChar = '\0';
            this.message.PlaceholderText = "";
            this.message.SelectedText = "";
            this.message.Size = new System.Drawing.Size(616, 34);
            this.message.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(858, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerNum);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerNum;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox answer;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox message;
        private System.Windows.Forms.Label timerCnt;
        private Guna.UI2.WinForms.Guna2HtmlLabel ansNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel range;
        private System.Windows.Forms.Button btnAutoPlaySingleTurn;
        private System.Windows.Forms.Button btnAutoplayWholeGame;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public System.Windows.Forms.RichTextBox conversation;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnReady;
    }
}