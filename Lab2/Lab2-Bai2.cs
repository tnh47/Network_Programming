using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521030_TranTienNhat
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập bộ lọc cho các tệp tin
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string fileName = openFileDialog.SafeFileName;
                    string filePath = openFileDialog.FileName;

                    // Đếm số dòng, số từ và số ký tự
                    string content;
                    int lineCount, wordCount, charCount;

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        content = sr.ReadToEnd();
                        lineCount = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        wordCount = content.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        charCount = content.Length;
                    }
                    richTextBox1.Text = content;

                    // Hiển thị nội dung của file
                    textBox1.Text = fileName;
                    textBox2.Text = filePath;
                    textBox3.Text = lineCount.ToString();
                    textBox4.Text = wordCount.ToString();
                    textBox5.Text = charCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
