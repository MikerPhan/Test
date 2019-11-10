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
using BanHang.Reposiroty_NhanVien;
//using BanHang.Business_Save;
//using BanHang.Business_Save;
using BanHang.Reposiroty.NhanVien;
using BanHang_Bussines_Save;
namespace BanTraSua
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var cmd = new NhanVien_Select_All())
            {
                this.nhanVienBindingSource.DataSource=cmd.Excute();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lay du lieu hien tai trong bang
            var curRow = this.nhanVienBindingSource.Current as NhanVien;
            using (var repo = new NhanVien_Bussiness_Save())
            {
                repo.item = curRow;
                repo.Execute();
            }
            this.button2_Click(null, null);
            MessageBox.Show("Lưu thành công !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curRow = this.nhanVienBindingSource.Current as NhanVien;
            using(var repo=new NhanVien_delete())
            {
                repo.MaNV = curRow.MaNV;
                repo.Execute();
            }
            this.button2_Click(null, null);
            MessageBox.Show("Xoá thành công !");
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
