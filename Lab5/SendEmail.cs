using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class SendEmail : Form
    {
        private List<string> attachmentPaths = new List<string>();
        public SendEmail()
        {
            InitializeComponent();
        }
        string username;
        string password;
        string SMTPHostName;
        Int32 SMTPHostPort;
        string attachmentPath;
        public SendEmail(string username, string password, string SMTPHostName, Int32 SMTPHostPort)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.SMTPHostName = SMTPHostName;
            this.SMTPHostPort = SMTPHostPort;
            senderGmailBox.Text = username;
        }

        private bool IsValidEmail(string email)
        {
            try
            {

                var addr = MailboxAddress.Parse(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void AddAttachment(string path)
        {
            attachmentPaths.Add(path);
            richTextBox1.Text = string.Join("\n", attachmentPaths);
        }

        private void send_Click(object sender, EventArgs e)
        {
            var senderEmail = senderGmailBox.Text;
            var receiverEmail = receiverBox.Text;

            if (!IsValidEmail(senderEmail) || !IsValidEmail(receiverEmail))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(SMTPHostName, SMTPHostPort, true);
                    client.Authenticate(username, password);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("", senderGmailBox.Text));
                    message.To.Add(new MailboxAddress("", receiverBox.Text));
                    message.Subject = subjectBox.Text;

                    var body = isHTML.Checked ? new TextPart("html") { Text = bodyBox.Text } : new TextPart("plain") { Text = bodyBox.Text };
                    var multipart = new Multipart("mixed");
                    multipart.Add(body);

                    foreach (var path in attachmentPaths)
                    {
                        var attachment = new MimePart()
                        {
                            Content = new MimeContent(File.OpenRead(path)),
                            ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                            ContentTransferEncoding = ContentEncoding.Base64,
                            FileName = Path.GetFileName(path)
                        };
                        multipart.Add(attachment);
                    }

                    message.Body = multipart;

                    client.Send(message);
                    client.Disconnect(true);

                    MessageBox.Show("Gửi email thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại. Lỗi: {ex.Message}");
            }
        }
        private void browserBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true; // Cho phép chọn nhiều tập tin
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in ofd.FileNames)
                    {
                        AddAttachment(path);
                    }
                }
            }
        }
    }
}
