using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            this.Close();
        }

        private void btn_Bai1_Client_Click(object sender, EventArgs e)
        {
            Bai1_Client tmpForm = new Bai1_Client();
            tmpForm.Show();
        }

        private void btn_Bai1_Server_Click(object sender, EventArgs e)
        {
            Bai1_Server tmpForm = new Bai1_Server();
            tmpForm.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 tmpForm = new Bai2();
            tmpForm.Show();
        }

        private void btn_Bai3_Client_Click(object sender, EventArgs e)
        {
            Bai3_Client tmpForm = new Bai3_Client();
            tmpForm.Show();
        }

        private void btn_Bai3_Server_Click(object sender, EventArgs e)
        {
            Bai3_Server tmpForm = new Bai3_Server();
            tmpForm.Show();
        }

        private void btn_Bai4_Client_Click(object sender, EventArgs e)
        {
            Bai4_Client tmpForm = new Bai4_Client();
            tmpForm.Show();
        }

        private void btn_Bai4_Server_Click(object sender, EventArgs e)
        {
            Bai4_Sever tmpForm = new Bai4_Sever();
            tmpForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
