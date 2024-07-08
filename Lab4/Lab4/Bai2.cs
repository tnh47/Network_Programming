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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private string Post_Web(string url, string data)
        {
            var byteArray = Encoding.UTF8.GetBytes(data);

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";

            var requestStream = request.GetRequestStream();
            requestStream.Write(byteArray, 0, byteArray.Length);
            requestStream.Close();

            var response = request.GetResponse();
            var responseStream = new StreamReader(response.GetResponseStream() ?? throw new Exception("Null response"));
            var responseData = responseStream.ReadToEnd();
            response.Close();

            return responseData;
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            try
            {
                if (!textBox1.Text.StartsWith("http://"))
                    textBox1.Text = textBox1.Text.Insert(0, "http://");

                richTextBox1.AppendText(Post_Web(textBox1.Text.Trim(), textBox2.Text.Trim()));
            }
            catch (Exception ex) { richTextBox1.AppendText(ex.Message); }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
