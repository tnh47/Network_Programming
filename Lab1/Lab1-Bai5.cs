using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521030_TranTienNhat
{
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }
        static bool ValidateInput(string[] strScores)
        {
            foreach (string strScore in strScores)
            {
                if (!double.TryParse(strScore, out double score) || score < 0 || score > 10)
                    return false;
            }
            return true;
        }
        static string ClassifyStudent(double averageScore, double[] scores)
        {
            bool isExcellent = averageScore >= 8 && !scores.Any(score => score < 6.5);
            bool isGood = averageScore >= 6.5 && !scores.Any(score => score < 5);
            bool isAverage = averageScore >= 5 && !scores.Any(score => score < 3.5);
            bool isWeak = averageScore >= 3.5 && !scores.Any(score => score < 2);
                        

            if (isExcellent)
                return "Giỏi";
            else if (isGood)
                return "Khá";
            else if (isAverage)
                return "TB";
            else if (isWeak)
                return "Yếu";
            else
                return "Kém";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Text = textBox1.Text.Trim().Replace(',', '.');
            string inputString = textBox1.Text;
            string[] strScores = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool isValid = ValidateInput(strScores);
            if (isValid) 
            {
                double[] scores = Array.ConvertAll(strScores, double.Parse);

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.ColumnCount = 4;

                for (int i = 0; i < scores.Length; i++)
                {
                    Label label = new Label();
                    label.Text = $"Môn {i + 1}: {Math.Round(scores[i], 2)}đ";
                    tableLayoutPanel.Controls.Add(label, i % 4, i / 4);
                }
                groupBox1.Controls.Add(tableLayoutPanel);

                double averageScore = scores.Average();
                textBox2.Text = Math.Round(averageScore, 2).ToString() + "đ"; ;

                double maxScore = scores.Max();
                double minScore = scores.Min();
                textBox4.Text = Math.Round(maxScore, 2).ToString() + "đ";
                textBox5.Text = Math.Round(minScore, 2).ToString() + "đ";

                // Tìm số môn đậu và không đậu
                int passCount = scores.Count(score => score >= 5);
                int failCount = scores.Length - passCount;
                textBox6.Text = passCount.ToString();
                textBox7.Text = failCount.ToString(); ;

                // Xếp loại sinh viên
                string studentClassification = ClassifyStudent(averageScore, scores);
                textBox3.Text = studentClassification.ToString();
            }
            else
            {
                MessageBox.Show("Đã nhập sai định dạng.");
            }

        }
    }
}
