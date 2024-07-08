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

namespace Lab2_22521030_TranTienNhat
{
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Xóa các mục trong ListView trước khi thêm mới
                listView1.Items.Clear();

                string folderPath = folderBrowserDialog.SelectedPath;

                // Lấy danh sách tất cả các file trong thư mục
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                FileInfo[] files = directoryInfo.GetFiles();

                // Hiển thị thông tin của mỗi file trong ListView
                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.CreationTime.ToString());
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
