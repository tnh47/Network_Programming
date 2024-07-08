using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Bai4_Client : Form
    {
        public Bai4_Client()
        {
            InitializeComponent();
        }
        private TcpClient client;
        private bool isConnected = false;
        private string userName;
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string message = userName + ": " + tb_mess.Text.Trim();
                SendMessage(message);
                tb_mess.Clear();
            }
            else
            {
                MessageBox.Show("Please connect to the server first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendMessage(string message)
        {
            if (isConnected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                client.GetStream().Write(buffer, 0, buffer.Length);
            }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            userName = tb_name.Text.Trim();
            if (!string.IsNullOrEmpty(userName))
            {
                if (!isConnected)
                {
                    try
                    {
                        client = new TcpClient("127.0.0.1", 5555);
                        isConnected = true;
                        btn_connect.Enabled = false;

                        Thread receiveThread = new Thread(ReceiveMessages);
                        receiveThread.Start();

                        // Gửi thông báo kết nối tới server
                        SendMessage("Connected to server.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ReceiveMessages()
        {
            try
            {
                while (!isExiting)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        MessageBox.Show("Server closed the connection.", "Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Hiển thị tin nhắn nhận được
                    rtb_message.Invoke((MethodInvoker)delegate {
                        rtb_message.AppendText(message + "\n");
                    });
                }
            }
            catch (Exception ex)
            {
                if (!isExiting) // Nếu không phải là do đang thoát, hiển thị lỗi
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isExiting = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            isExiting = true; // Đánh dấu rằng ứng dụng đang thoát

            if (isConnected)
            {
                // Bắt đầu một luồng mới để đóng kết nối
                Thread closeThread = new Thread(CloseConnection);
                closeThread.Start();
            }
            else
            {
                // Nếu không kết nối, đóng form ngay lập tức
                this.Close();
            }
        }
        private void CloseConnection()
        {
            try
            {
                // Đóng kết nối
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng form sau khi kết nối đã được đóng
                this.Invoke((MethodInvoker)delegate {
                    this.Close();
                });
            }
        }
    }
}
