using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab2_22521030_TranTienNhat
{
    public partial class Lab2_Bai4 : Form
    {
        [Serializable]
        public class Student
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string SDT { get; set; }
            public double DToan { get; set; }
            public double DVan { get; set; }
            public double DTB { get; set; }

            public void TinhDTB()
            {
                DTB = (DToan + DVan) / 2;
                DTB = Math.Round(DTB, 2);
            }
            public string ToString_Input()
            {
                return $"{MSSV}\n{HoTen}\n{SDT}\n{DToan}\n{DVan}\n";
            }
            public override string ToString()
            {
                return $"{MSSV}\n{HoTen}\n{SDT}\n{DToan}\n{DVan}\n{DTB}\n";
            }
        }

        private List<Student> students = new List<Student>();

        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            listView.Items.Clear();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.MSSV);
                item.SubItems.Add(student.HoTen);
                item.SubItems.Add(student.SDT);
                item.SubItems.Add(student.DToan.ToString());
                item.SubItems.Add(student.DVan.ToString());
                listView.Items.Add(item);
            }
        }
        private void btn_addSV_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Text.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] data = line.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (data.Length != 5)
                {
                    MessageBox.Show("Dữ liệu của sinh viên không hợp lệ");
                    students.Clear();
                    return;
                }

                string mssv = data[0].Trim();
                string hoTen = data[1].Trim();
                string sdt = data[2].Trim();

                if (!double.TryParse(data[3].Trim().Replace(',', '.'), out double diemToan) ||
                    !double.TryParse(data[4].Trim().Replace(',', '.'), out double diemVan) ||
                    diemToan < 0 || diemToan > 10 || diemVan < 0 || diemVan > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ cho sinh viên có MSSV: " + mssv);
                    continue;
                }
                diemToan = Math.Round(diemToan, 2);
                diemVan = Math.Round(diemVan, 2);
                if (students.Any(st => st.MSSV == mssv))
                {
                    MessageBox.Show("MSSV đã tồn tại: " + mssv);
                    continue;
                }
                Student student = new Student
                {
                    MSSV = mssv,
                    HoTen = hoTen,
                    SDT = sdt,
                    DToan = diemToan,
                    DVan = diemVan
                };
                students.Add(student);
            }

            LoadData();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Save input file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        richTextBox2.Clear();
                        foreach (Student st in students)
                        {
                            richTextBox2.Text += st.ToString_Input();
                            richTextBox2.Text += "\n";
                        }
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, students);
                    }
                    MessageBox.Show("Học viên đã được lưu vào file input.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_caldtb_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Student st in students)
                {
                    st.TinhDTB();
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Save output file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, students);
                    }
                    MessageBox.Show("ĐTB đã được lưu vào file " + saveFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn tên file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            output.Clear();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text File|*.txt";
                openFileDialog.Title = "Open output file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        List<Student> list = (List<Student>)bf.Deserialize(fs);

                        foreach (Student st in list)
                        {
                            output.Text += st.ToString();
                            output.Text += "\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            students.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            listView.Items.Clear();
            output.Clear();
        }
    }
}
