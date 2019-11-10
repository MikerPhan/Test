using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




using BanHang.Reposiroty_NhaCungCap;
using BanHang.Domain;
using BanHang_Bussiness_Save;


namespace BanTraSua
{
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmd = new NhaCungCap_Select_All())
            {
                this.nhaCungCapBindingSource.DataSource = cmd.Excute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu hiện tại trong bảng
            var curRow = this.nhaCungCapBindingSource.Current as NhaCungCap;
            using (var repo= new NhaCungCap_Bussiness_Save() )
            {
                repo.item = curRow;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Lưu thành công !");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curRow = this.nhaCungCapBindingSource.Current as NhaCungCap;
            using(var repo=new NhaCungCap_delete())
            {
                repo.MaNCC = curRow.MaNCC;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Xoá thành công !");
        }

        private void tenNCCLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
