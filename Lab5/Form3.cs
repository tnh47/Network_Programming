using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form3 : Form
    {
        //MailReader mailReader;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993);
            try
            {
                client.Authenticate(textBox1.Text, textBox2.Text);
            }
            catch (AuthenticationException)
            {
                label3.Text = "Tài khoản hoặc mật khẩu không đúng!";
                return;
            }

            // Lấy danh sách thư từ hòm thư Inbox
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            listView1.Clear();
            listView1.Columns.Add("Email", 400);
            listView1.Columns.Add("From", 250);
            listView1.Columns.Add("Thời gian", 250);
            listView1.View = View.Details;

            // Lấy danh sách thư email và sắp xếp theo thời gian ngược lại
            var sortedMessages = inbox.OrderByDescending(message => message.Date);

            foreach (var message in sortedMessages)
            {
                ListViewItem name = new ListViewItem(message.Subject);

                ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                name.SubItems.Add(from);

                ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                name.SubItems.Add(date);

                listView1.Items.Add(name);
            }

            client.Disconnect(true);
        }



        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var index = listView1.FocusedItem.Index;

            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993);
            try
            {
                client.Authenticate(textBox1.Text, textBox2.Text);
            }
            catch (AuthenticationException)
            {
                label3.Text = "Tài khoản hoặc mật khẩu không đúng!";
                return;
            }

            // Lấy danh sách thư từ hòm thư Inbox
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            // Lấy nội dung của email đã chọn
            var message = inbox.GetMessage(index);
            // Hiển thị nội dung HTML của email trong WebBrowser Control
            var webBrowserForm = new Form();
            var webBrowser = new WebBrowser();
            webBrowserForm.Controls.Add(webBrowser);
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentText = string.IsNullOrEmpty(message.TextBody) ? message.HtmlBody : message.TextBody;
            webBrowserForm.Size = new Size(800, 600);

            webBrowserForm.ShowDialog();

            client.Disconnect(true);
        }
    }
}
