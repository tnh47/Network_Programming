using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private void WebBrower_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Bai4_ViewCode form = new Bai4_ViewCode();
            form.MyProperty = client.DownloadString(tb_url.Text);
            form.Show();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            Bai4_Download form = new Bai4_Download();
            form.MyProperty = tb_url.Text;
            form.Show();
        }
        WebBrowser webTab = null;
        private void btn_tab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("http://www.google.com");
            tb_url.Text = "http://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(tb_url.Text);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(tb_url.Text);
            webBrowser.DocumentCompleted += WebBrower_DocumentCompleted;
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://www.google.com");
            tb_url.Text = "http://www.google.com";
            webBrowser.DocumentCompleted += WebBrower_DocumentCompleted;
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }
    }
}
