using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab2_22521030_TranTienNhat
{
    partial class Lab2_Bai4
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_caldtb = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addSV = new System.Windows.Forms.Button();
            this.grbox_view = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.column_MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_toan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_van = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbox_input = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.grbox_view.SuspendLayout();
            this.grbox_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Location = new System.Drawing.Point(838, 194);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 28);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_output
            // 
            this.btn_output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_output.Location = new System.Drawing.Point(954, 136);
            this.btn_output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(117, 28);
            this.btn_output.TabIndex = 0;
            this.btn_output.Text = "Mở file output";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_caldtb
            // 
            this.btn_caldtb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_caldtb.Location = new System.Drawing.Point(954, 61);
            this.btn_caldtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_caldtb.Name = "btn_caldtb";
            this.btn_caldtb.Size = new System.Drawing.Size(117, 28);
            this.btn_caldtb.TabIndex = 0;
            this.btn_caldtb.Text = "Tính ĐTB";
            this.btn_caldtb.UseVisualStyleBackColor = true;
            this.btn_caldtb.Click += new System.EventHandler(this.btn_caldtb_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Location = new System.Drawing.Point(728, 136);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 28);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Lưu DS";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addSV
            // 
            this.btn_addSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addSV.Location = new System.Drawing.Point(728, 61);
            this.btn_addSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addSV.Name = "btn_addSV";
            this.btn_addSV.Size = new System.Drawing.Size(117, 28);
            this.btn_addSV.TabIndex = 0;
            this.btn_addSV.Text = "Thêm SV";
            this.btn_addSV.UseVisualStyleBackColor = true;
            this.btn_addSV.Click += new System.EventHandler(this.btn_addSV_Click);
            // 
            // grbox_view
            // 
            this.grbox_view.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbox_view.Controls.Add(this.listView);
            this.grbox_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grbox_view.Location = new System.Drawing.Point(21, 236);
            this.grbox_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_view.Name = "grbox_view";
            this.grbox_view.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_view.Size = new System.Drawing.Size(680, 235);
            this.grbox_view.TabIndex = 3;
            this.grbox_view.TabStop = false;
            this.grbox_view.Text = "Danh sách sinh viên";
            // 
            // listView
            // 
            this.listView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_MSSV,
            this.column_name,
            this.column_phone,
            this.column_toan,
            this.column_van});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 25);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(649, 204);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // column_MSSV
            // 
            this.column_MSSV.Text = "MSSV";
            this.column_MSSV.Width = 80;
            // 
            // column_name
            // 
            this.column_name.Text = "Họ Tên";
            this.column_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_name.Width = 120;
            // 
            // column_phone
            // 
            this.column_phone.Text = "SĐT";
            this.column_phone.Width = 100;
            // 
            // column_toan
            // 
            this.column_toan.Text = "Điểm Toán";
            this.column_toan.Width = 100;
            // 
            // column_van
            // 
            this.column_van.Text = "Điểm Văn";
            this.column_van.Width = 100;
            // 
            // output
            // 
            this.output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.output.Location = new System.Drawing.Point(933, 261);
            this.output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(165, 204);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(930, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // grbox_input
            // 
            this.grbox_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbox_input.Controls.Add(this.richTextBox1);
            this.grbox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grbox_input.Location = new System.Drawing.Point(21, 21);
            this.grbox_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_input.Name = "grbox_input";
            this.grbox_input.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_input.Size = new System.Drawing.Size(680, 206);
            this.grbox_input.TabIndex = 1;
            this.grbox_input.TabStop = false;
            this.grbox_input.Text = "Nhập thông tin sinh viên";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(662, 176);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(728, 262);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(165, 203);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // Lab2_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 472);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_caldtb);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.output);
            this.Controls.Add(this.grbox_view);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_addSV);
            this.Controls.Add(this.grbox_input);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab2_Bai4";
            this.Text = "Lab2-Bai4";
            this.grbox_view.ResumeLayout(false);
            this.grbox_input.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grbox_view;
        private ListView listView;
        private ColumnHeader column_MSSV;
        private ColumnHeader column_name;
        private ColumnHeader column_phone;
        private ColumnHeader column_toan;
        private ColumnHeader column_van;
        private RichTextBox output;
        private Label label1;
        private Button btn_delete;
        private Button btn_output;
        private Button btn_caldtb;
        private Button btn_save;
        private Button btn_addSV;
        private GroupBox grbox_input;
        private RichTextBox richTextBox1;
        private Label label2;
        private RichTextBox richTextBox2;
    }
}