using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHang.Reposiroty_HangHoa;
using BanHang_Bussines_Save;
using BanHang.Library_01;
using BanHang.Domain;
using BanHang_Bussiness_Save;

namespace BanTraSua
{
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var cmd=new HangHoa_Select_All())
            {
                this.hangHoaBindingSource.DataSource = cmd.Excute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu hiện tại trong bảng
            var curRow = this.hangHoaBindingSource.Current as HangHoa;
            using (var repo = new HangHoa_Bussiness_Save())
            {
                repo.item = curRow;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Lưu thành công !");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curRow = this.hangHoaBindingSource.Current as HangHoa;
            using (var repo=new HangHoa_delete())
            {
                repo.MaHH = curRow.MaHH;
                repo.Execute();
            }
            this.button1_Click(null, null);
            MessageBox.Show("Xoá thành công !");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           using(var i = new in_HangHoa())
           {
               i.ShowDialog(this);
           }
        }
    }
}
