using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Home
{
    public partial class Bai4_Sever : Form
    {
        public Bai4_Sever()
        {
            InitializeComponent();
        }
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isServerRunning = false;

        private void btn_listen_Click(object sender, EventArgs e)
        {
            if (!isServerRunning)
            {
                server = new TcpListener(IPAddress.Any, 5555);
                server.Start();
                isServerRunning = true;
                btn_listen.Enabled = false;
                string ipAddress = ((IPEndPoint)server.LocalEndpoint).Address.ToString();
                int port = ((IPEndPoint)server.LocalEndpoint).Port;
                string message = "Server is running on " + ipAddress + ":" + port;
                rtb_mess.Invoke((MethodInvoker)delegate {
                    rtb_mess.AppendText(message + "\n");
                });
                Thread serverThread = new Thread(ServerLoop);
                serverThread.Start();
            }
        }

        private void ServerLoop()
        {
            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    // Kiểm tra biến cờ trước khi thêm client vào danh sách
                    if (isServerShuttingDown)
                    {
                        break;
                    }

                    clients.Add(client);

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();

                    // Hiển thị thông báo khi có client mới kết nối
                    rtb_mess.Invoke((MethodInvoker)delegate {
                        rtb_mess.AppendText("New client connected from: " + client.Client.RemoteEndPoint.ToString() + "\n");
                    });
                }
            }
            catch (Exception ex)
            {
                if (!isServerShuttingDown) // Kiểm tra nếu không phải là do đang dừng máy chủ
                {
                    MessageBox.Show(ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void BroadcastMessage(string message)
        {
            foreach (TcpClient client in clients)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                client.GetStream().Write(buffer, 0, buffer.Length);
            }

            // Hiển thị tin nhắn trên richTextBox của server
            rtb_mess.Invoke((MethodInvoker)delegate {
                rtb_mess.AppendText(message + "\n");
            });
        }
        private bool isServerShuttingDown = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (isServerRunning)
            {
                // Đánh dấu rằng server đang tắt
                isServerShuttingDown = true;

                // Đóng tất cả các kết nối client
                foreach (TcpClient client in clients)
                {
                    client.Close();
                }
                // Đóng server
                server.Stop();
            }
            // Đóng form
            this.Close();
        }
        private void HandleClient(TcpClient client)
        {
            try
            {
                while (true)
                {
                    // Kiểm tra xem server có đang tắt không
                    if (isServerShuttingDown)
                    {
                        break;
                    }

                    byte[] buffer = new byte[1024];
                    int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        client.Close();
                        clients.Remove(client);
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Gửi tin nhắn nhận được đến tất cả các client khác
                    BroadcastMessage(message);
                }
            }
            catch (Exception)
            {
                clients.Remove(client);
            }
        }
    }
}
