using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Bai1_Client : Form
    {
        public Bai1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textPort.Text != null && textHostIP.Text != null)
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(textHostIP.Text, int.Parse(textPort.Text));
                Byte[] data = Encoding.UTF8.GetBytes(textMessage.Text);
                udpClient.Send(data, data.Length);
                textMessage.Clear();
                udpClient.Close();
            }
            else
            {
                MessageBox.Show("Error! Nhap lai IP va Port", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
