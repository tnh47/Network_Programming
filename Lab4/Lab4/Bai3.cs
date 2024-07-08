using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "HTML|*.html";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tb_dir.Text = openFileDialog.FileName;
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (tb_dir.Text == "" || tb_url.Text == " ")
                MessageBox.Show("Ô Path hoặc URL đang để trống!", "THÔNG BÁO", MessageBoxButtons.OK);

            WebClient client = new WebClient();
            Stream res = client.OpenRead(tb_url.Text);
            client.DownloadFile(tb_url.Text, tb_dir.Text);
            StreamReader reader = new StreamReader(res);
            string line = reader.ReadToEnd();
            richTextBox1.Text = client.DownloadString(tb_url.Text);

            MessageBox.Show("Download thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            tb_dir.Clear();
            tb_url.Clear();
            richTextBox1.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
