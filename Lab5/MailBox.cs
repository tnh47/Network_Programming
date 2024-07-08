using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MimeKit;
using Lab05;

namespace Lab05
{
    public partial class MailBox : Form
    {

        public MailBox()
        {
            InitializeComponent();
        }
        public class Email
        {
            public string Subject { get; set; }
            public string From { get; set; }
            public string Date { get; set; }
            public string TextBody { get; set; }
            public string HtmlBody { get; set; }
            public List<MimeEntity> Attachments { get; set; } = new List<MimeEntity>();
        }
        List<Email> emails = new List<Email>();
        string username = LogIn.Username;
        string password = LogIn.Password;
        string SMTPHost = LogIn.SMTPHost;
        int SMTPPort = LogIn.SMTPPort;
        string IMAPHost = LogIn.IMAPHost;
        int IMAPPort = LogIn.IMAPPort;
        ImapClient client = LogIn.client;
        bool isLoggedIn = true;
        private void DisplayEmails()
        {
            listView1.Items.Clear();
            foreach (var email in emails)
            {
                ListViewItem item = new ListViewItem(email.Subject);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, email.From));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, DateTime.Parse(email.Date).ToString("dd/MM/yyyy HH:mm:ss")));
                listView1.Items.Add(item);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (isLoggedIn)
                {
                    listView1.Items.Clear();

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    emails.Clear(); // Clear the emails list before adding new emails

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var email = new Email
                        {
                            Subject = message.Subject,
                            From = message.From.ToString(),
                            Date = message.Date.ToString(),
                            TextBody = message.TextBody,
                            HtmlBody = message.HtmlBody
                        };
                        foreach (var attachment in message.Attachments)
                        {
                            email.Attachments.Add(attachment);
                        }
                        emails.Add(email);

                    }

                    // Sắp xếp danh sách email theo thời gian giảm dần
                    emails = emails.OrderByDescending(email => DateTime.Parse(email.Date)).ToList();

                    // Hiển thị email trong listView1
                    DisplayEmails();
                    MessageBox.Show("Đã tải lại hộp thư!");
                }
                else
                {
                    MessageBox.Show("Vui lòng đăng nhập trước khi thực hiện refresh!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                if (selectedIndex >= 0 && selectedIndex < emails.Count)
                {
                    Email selectedEmail = emails[selectedIndex];
                    string subject = selectedEmail.Subject;
                    string from = selectedEmail.From;
                    string to = username;
                    string date = selectedEmail.Date;
                    string textBody = selectedEmail.TextBody;
                    string htmlBody = selectedEmail.HtmlBody;
                    List<MimeEntity> attachments = selectedEmail.Attachments;
                    ViewEmail viewEmail = new ViewEmail(subject, from, to, date, textBody, htmlBody, attachments);
                    viewEmail.Show();
                }
            }
        }


        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string username = this.username;
            string password = this.password;
            string SMTPHostName = SMTPHost;
            Int32 SMTPHostPort = SMTPPort;
            SendEmail sendEmail = new SendEmail(username, password, SMTPHostName, SMTPHostPort);
            sendEmail.Show();
        }

        private async void MailBox_Load(object sender, EventArgs e)
        {
            // Hiển thị ProgressBar khi bắt đầu tải email
            progressBar.Visible = true;

            listView1.Columns.Add("Email", 300);
            listView1.Columns.Add("From", 100);
            listView1.Columns.Add("Thời gian", 100);
            listView1.View = View.Details;

            try
            {
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                emails.Clear(); // Clear the emails list before adding new emails

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    var email = new Email
                    {
                        Subject = message.Subject,
                        From = message.From.ToString(),
                        Date = message.Date.ToString(),
                        TextBody = message.TextBody,
                        HtmlBody = message.HtmlBody
                    };
                    foreach (var attachment in message.Attachments)
                    {
                        email.Attachments.Add(attachment);
                    }
                    emails.Add(email);

                    // Cập nhật giá trị ProgressBar dựa trên tiến độ tải email
                    progressBar.Value = (int)(((float)(i + 1) / inbox.Count) * 100);
                    await Task.Delay(10);
                }

                // Sắp xếp danh sách email theo thời gian giảm dần
                emails = emails.OrderByDescending(email => DateTime.Parse(email.Date)).ToList();

                // Hiển thị email trong listView1
                DisplayEmails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Ẩn ProgressBar khi quá trình tải email hoàn tất
            progressBar.Visible = false;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }

        private void MailBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
