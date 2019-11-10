using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHang.Domain;
using BanHang.Library_01;
using BanHang.Reposiroty_KhachHang;
using BanHang_Bussiness_Save;

namespace BanTraSua
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmd = new KhachHang_Select_All()) 
            {
                this.khachHangBindingSource.DataSource = cmd.Excute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu hiện tại trong bảng
            var curRow = this.khachHangBindingSource.Current as KhachHang;
            using(var repo=new KhachHang_Bussiness_Save())
            {
                repo.item = curRow;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Lưu thành công !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curRow = this.khachHangBindingSource.Current as KhachHang;
            using(var repo=new KhachHang_delete())
            {
                repo.MaKH = curRow.MaKH;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Xoá thành công !");
        }

        private void sDTLabel_Click(object sender, EventArgs e)
        {

        }

        private void diaChiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void maKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void diaChiLabel_Click(object sender, EventArgs e)
        {

        }

        private void sDTTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tenKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
