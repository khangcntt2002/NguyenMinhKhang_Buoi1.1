using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenMinhKhang_Buoi1._1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!double.TryParse(textBox1.Text, out a) ||
                !double.TryParse(textBox2.Text, out b) ||
                !double.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập tất cả các hệ số dưới dạng số hợp lệ.");
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("Hệ số a không thể bằng 0.");
                return;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
               textBox4.Text = $"Phương trình có hai nghiệm thực phân biệt:\n x1 = {root1}\n x2 = {root2}";
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
               textBox4.Text = $"Phương trình có một nghiệm thực duy nhất:\n x = {root}";
            }
            else
            {
              textBox4.Text = "Phương trình không có nghiệm thực.";
            }

        }
    }
}
