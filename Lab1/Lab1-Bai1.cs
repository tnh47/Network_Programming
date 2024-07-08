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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
                int num1, num2;
                long sum = 0;
                if ((int.TryParse(textBox1.Text.Trim(), out num1)) && int.TryParse(textBox2.Text.Trim(), out num2))
                {
                    num1 = Int32.Parse(textBox1.Text.Trim());
                    num2 = Int32.Parse(textBox2.Text.Trim());
                    sum = num1 + num2;
                    textBox3.Text = sum.ToString();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

