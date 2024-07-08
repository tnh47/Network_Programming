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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1;
                string num1string;
                string numconvert = "";
                if ((int.TryParse(textBox1.Text.Trim(), out num1)))
                {
                    num1 = Int32.Parse(textBox1.Text.Trim());
                    if (comboBox1.Text == comboBox2.Text)
                    {
                        numconvert = num1.ToString();
                    }
                    if (comboBox1.Text == "Decimal")
                    {
                        switch (comboBox2.Text)
                        {
                            case "Binary":
                                numconvert = Convert.ToString(num1, 2);
                                break;
                            case "Hexadecimal":
                                numconvert = Convert.ToString(num1, 16).ToUpper();
                                break;
                        }
                    }
                    if (comboBox1.Text == "Binary")
                    {
                        switch (comboBox2.Text)
                        {
                            case "Decimal":
                                numconvert = Convert.ToInt32(num1.ToString(), 2).ToString();
                                break;
                            case "Hexadecimal":
                                int decnum = Convert.ToInt32(num1.ToString(), 2);
                                numconvert = Convert.ToString(decnum, 16).ToString().ToUpper();
                                break;
                        }
                    }
                    if (comboBox1.Text == "Hexadecimal")
                    {
                        num1string = num1.ToString();
                        switch (comboBox2.Text)
                        {
                            case "Decimal":
                                numconvert = Convert.ToInt32(num1string, 16).ToString();
                                break;
                            case "Binary":
                                int decnum = Convert.ToInt32(num1string, 16);
                                numconvert = Convert.ToString(decnum, 2);
                                break;
                        }
                    }
                }
                else
                {
                    num1string = textBox1.Text.Trim();
                    if (comboBox1.Text == comboBox2.Text)
                    {
                        numconvert = num1string;
                    }
                    if (comboBox1.Text == "Hexadecimal")
                    {
                        switch (comboBox2.Text)
                        {
                            case "Decimal":
                                numconvert = Convert.ToInt32(num1string, 16).ToString();
                                break;
                            case "Binary":
                                int decnum = Convert.ToInt32(num1string, 16);
                                numconvert = Convert.ToString(decnum, 2);
                                break;
                        }
                    }
                    if (comboBox1.Text == "Decimal" || comboBox1.Text == "Binary")
                    {
                        numconvert = "";
                        MessageBox.Show("Lỗi !");
                    }
                }
                textBox2.Text = numconvert;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}