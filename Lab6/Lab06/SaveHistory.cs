using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab06
{
    public partial class SaveHistory : Form
    {
        private string text;

        public SaveHistory(string text)
        {
            InitializeComponent();
            this.text = text;
        }

        private void SaveHistory_Load(object sender, EventArgs e)
        {
            CreateGist(text);
        }

        private async void CreateGist(string content)
        {
            string gistDescription = "Lịch sử trò chơi";
            bool isPublic = true;
            string personalAccessToken = "YOUR_GitHub_Personal_Access_Token";

            var gist = new
            {
                description = gistDescription,
                @public = isPublic,
                files = new Dictionary<string, object>
                {
                    { "history.txt", new { content = content } }
                }
            };

            string gistJson = JsonConvert.SerializeObject(gist);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "CSharp-App");
                client.DefaultRequestHeaders.Add("Authorization", "token " + personalAccessToken);

                var response = await client.PostAsync(
                    "https://api.github.com/gists",
                    new StringContent(gistJson, Encoding.UTF8, "application/json")
                );

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic gistResult = JsonConvert.DeserializeObject(result);
                    textBox1.Text = $"Lịch sử trò chơi được lưu tại: \r\n{gistResult.html_url}";
                }
                else
                {
                    MessageBox.Show("Lỗi: " + response.StatusCode);
                }
            }
        }
    }
}
