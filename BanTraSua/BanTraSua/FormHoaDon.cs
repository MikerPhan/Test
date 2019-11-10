using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHang.Reposiroty_HoaDon;
using BanHang.Domain;
using BanHang_Bussiness_Save;

namespace BanTraSua
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maHDLabel_Click(object sender, EventArgs e)
        {

        }

        private void maKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void maHDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maNVLabel_Click(object sender, EventArgs e)
        {

        }

        private void maNVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngayLapHDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ngayLapHDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmd = new HoaDon_Select_All())
            {
                this.hoaDonBindingSource.DataSource = cmd.Excute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu trong bảng 
            var curRow = this.hoaDonBindingSource.Current as HoaDon;
            using(var repo=new HoaDon_Bussiness_Save())
            {
                repo.item = curRow;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Lưu thành công !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curRow = this.hoaDonBindingSource.Current as HoaDon;
            using(var repo=new HoaDon_delete())
            {
                repo.MaHD = curRow.MaHD;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Xoá thành công !");
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var i = new in_HoaDon())
            {
                i.ShowDialog(this);
            }
        }
    }
}
