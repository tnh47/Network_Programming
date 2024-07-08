using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 tmpForm = new Bai1();
            tmpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 tmpForm = new Bai2();
            tmpForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 tmpForm = new Bai3();
            tmpForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 tmpForm = new Bai4();
            tmpForm.Show();
        }
    }
}
