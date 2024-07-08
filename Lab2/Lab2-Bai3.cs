using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521030_TranTienNhat
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                try
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog1.Title = "Save Calculation Results";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string outputFilePath = saveFileDialog1.FileName;

                        string[] lines = richTextBox1.Lines;

                        using (StreamWriter sw = new StreamWriter(outputFilePath))
                        {
                            foreach (string line in lines)
                            {
                                Match match = Regex.Match(line, @"(-?\d+(\.\d+)?)\s*([+\-*/])\s*(-?\d+(\.\d+)?)");

                                if (match.Success)
                                {
                                    double num1 = double.Parse(match.Groups[1].Value);
                                    char op = char.Parse(match.Groups[3].Value);
                                    double num2 = double.Parse(match.Groups[4].Value);

                                    double result = 0;

                                    switch (op)
                                    {
                                        case '+':
                                            result = num1 + num2;
                                            break;
                                        case '-':
                                            result = num1 - num2;
                                            break;
                                        case '*':
                                            result = num1 * num2;
                                            break;
                                        case '/':
                                            if (num2 != 0)
                                                result = num1 / num2;
                                            else
                                            {
                                                sw.WriteLine("Lỗi: Chia cho 0");
                                                continue;
                                            }
                                            break;
                                    }
                                    sw.WriteLine($"{num1} {op} {num2} = {result}");
                                }
                                else
                                {
                                    sw.WriteLine(line);
                                }
                            }
                        }

                        MessageBox.Show("Hoàn thành tính toán. Kiểm tra file output để xem kết quả");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("No content to save!");
            }
        }
    }

}
