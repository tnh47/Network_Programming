﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521030_TranTienNhat
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 form2 = new Lab2_Bai1();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 form2 = new Lab2_Bai2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 form2 = new Lab2_Bai3();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 form2 = new Lab2_Bai4();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 form2 = new Lab2_Bai5();
            form2.Show();
        }
    }
}
