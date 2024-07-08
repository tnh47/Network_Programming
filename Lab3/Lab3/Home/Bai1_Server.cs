using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home
{
    public partial class Bai1_Server : Form
    {
        private delegate void UpdateMessageDel(String info);
        public Bai1_Server()
        { 
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnB1Listen_Click(object sender, EventArgs e)
        {
            Thread threadUDPServer = new Thread(new ThreadStart(serverThread));
            threadUDPServer.Start();
            MessageBox.Show("Listening on port: " + ServerPortB1.Text.ToString());
        }

        public void UpdateMessage(string message)
        {
            //kiem tra xem phuong thuc hien tai co duoc goi tu luong khac hay khong
            if (messagelist1.InvokeRequired)
            {
                var index = new UpdateMessageDel(UpdateMessage);
                messagelist1.Invoke(index, new object[] { message }); //goi lai tren luong chinh
                return;
            }
            messagelist1.Items.Add(message);
        }

        public void serverThread()
        {
            bool checkPort;
            checkPort = Int32.TryParse(ServerPortB1.Text.Trim(), out int port);
            if (!checkPort)
            {
                MessageBox.Show("Wrong Port!");
                return;
            }
            UdpClient udpClient = new UdpClient(Int32.Parse(ServerPortB1.Text));
            while (true)
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiveBytes = udpClient.Receive(ref iPEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string message = iPEndPoint.Address.ToString() + ": " + returnData.ToString();
                UpdateMessage(message);
            }
        }

    }
}
