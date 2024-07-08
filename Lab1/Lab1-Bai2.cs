using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521030_TranTienNhat
{
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim().Replace(',', '.');
            textBox2.Text = textBox2.Text.Trim().Replace(',', '.');
            textBox3.Text = textBox3.Text.Trim().Replace(',', '.');
            double num1, num2, num3, max, min;
            if ((double.TryParse(textBox1.Text.Trim(), out num1)) && double.TryParse(textBox2.Text.Trim(), out num2) && (double.TryParse(textBox3.Text.Trim(), out num3)))
            {
                num1 = Double.Parse(textBox1.Text.Trim());
                num2 = Double.Parse(textBox2.Text.Trim());
                num3 = Double.Parse(textBox3.Text.Trim());
                max = Math.Max(num1, Math.Max(num2, num3));
                min = Math.Min(num1, Math.Min(num2, num3));
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
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
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
