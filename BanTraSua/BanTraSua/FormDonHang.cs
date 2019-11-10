using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHang.Reposiroty_DonHang;
using BanHang_Bussines_Save;
using BanHang.Library_01;
using BanHang.Domain;
using BanHang_Bussiness_Save;

namespace BanTraSua
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmd = new DonHang_Select_All())
            {
                this.donHangBindingSource.DataSource = cmd.Excute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu hiện tại trong bảng
            var curRow = this.donHangBindingSource.Current as DonHang;
            using (var repo = new DonHang_Bussiness_Save())
            {
                repo.item = curRow;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Lưu thành công !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curRow = this.donHangBindingSource.Current as DonHang;
            using (var repo = new DonHang_delete())
            {
                repo.MaDH = curRow.MaDH;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Xoá thành công !");
        }
    }
}
