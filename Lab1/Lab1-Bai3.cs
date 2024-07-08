using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_22521030_TranTienNhat
{
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            string s = "";
            if ((int.TryParse(textBox1.Text.Trim(), out num1)))
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                switch (num1)
                {
                    case 0:
                        s = "Không";
                        break;
                    case 1:
                        s = "Một";
                        break;
                    case 2:
                        s = "Hai";
                        break;
                    case 3:
                        s = "Ba";
                        break;
                    case 4:
                        s = "Bốn";
                        break;
                    case 5:
                        s = "Năm";
                        break;
                    case 6:
                        s = "Sáu";
                        break;
                    case 7:
                        s = "Bảy";
                        break;
                    case 8:
                        s = "Tám";
                        break;
                    case 9:
                        s = "Chín";
                        break;
                    default:
                        MessageBox.Show("Vui lòng nhập số từ 0 đến 9");
                        break;
                }
                textBox2.Text = s;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
