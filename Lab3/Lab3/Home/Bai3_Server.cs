using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Bai3_Server : Form
    {
        public Bai3_Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        Socket Client;
        IPEndPoint IPEP;
        TcpListener Listener;
        
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_Listen.Enabled = false;
        }
        void Connect()
        {
            IPEP = new IPEndPoint(IPAddress.Any, 9000);
            Listener = new TcpListener(IPEP);
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Listener.Start();
                    Client = Listener.AcceptSocket();
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(Client);
                }
            });
            thread.IsBackground = true;
            thread.Start();
            void Receive(Object obj)
            {
                while (true)
                {
                    Socket client = obj as Socket;
                    byte[] recv = new byte[1000];
                    Client.Receive(recv);
                    string str = Encoding.UTF8.GetString(recv);
                    Addmessage(str);

                }
            }
        }
        void Addmessage(string message)
        {
            listView1.Items.Add(message);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bai3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
