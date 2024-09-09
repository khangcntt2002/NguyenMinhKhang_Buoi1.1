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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
        public bool Kiemtrasnt(int n)
        {
            int dem = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        private void txt_Nhap_TextChanged(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txt_Nhap.Text != string.Empty)
            {
                if (Kiemtrasnt(int.Parse(txt_Nhap.Text)))
                {
                    txt_Kq.Text = "La So Nguyen To";

                }
                else
                {
                    txt_Kq.Text = "Khong Phai La So Nguyen To";
                }
                for(int i = 2;i< int.Parse(txt_Nhap.Text);i++)
                {

                    if(Kiemtrasnt(i))
                    {
                        kq += " " + i;
                    }
                }
                txt_N.Text = kq;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
