using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanTraSua
{
    public partial class QuanLiBanTraSua : Form
    {
        public QuanLiBanTraSua()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void QuanLiBanTraSua_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
            Form frm = new dangNhap();
            frm.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormHangHoa hh = new FormHangHoa())
            {
                hh.ShowDialog(this);
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormNhanVien nv = new FormNhanVien())
            {
                nv.ShowDialog(this);
            }
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormKhachHang hh = new FormKhachHang())
            {
                hh.ShowDialog(this);
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormNhaCungCap ncc = new FormNhaCungCap())
            {
                ncc.ShowDialog(this);
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormHoaDon hd = new FormHoaDon())
            {
                hd.ShowDialog(this);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormDonHang dh = new FormDonHang())
            {
                dh.ShowDialog(this);
            }
        }

        /*private void danhSáchThuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           // using (FormBanHang bhts = new FormBanHang())
            //{
            //    bhts.ShowDialog(this);
            //}
        }*/

        private void bánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using(var i = new FormBanHang())
            {
                i.ShowDialog(this);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
