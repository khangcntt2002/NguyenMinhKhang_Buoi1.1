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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        List<int> arr_dayso = new List<int>(); // khai báo biến 


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonhap = int.Parse(txt_nhapso.Text);
            arr_dayso.Add(sonhap);
            txt_dayvuanhap.Text = " ";
            foreach (int i in arr_dayso)
            {
                txt_dayvuanhap.Text += i + " ";



            }
            txt_nhapso.Text= " ";
        }
    }
}
