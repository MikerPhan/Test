using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BanHang.Reposiroty_NhanVien;
using BanHang.Reposiroty_HoaDon;
using BanHang.Reposiroty_HangHoa;
using BanHang.Domain;
using BanHang.Library_01;
using BanHang_Bussiness_Save;

namespace BanTraSua
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void hangHoaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmd = new HangHoa_Select_All())
            {
                this.hangHoaBindingSource.DataSource = cmd.Excute();
            }
            
        }

        List<BanHang_TraSua> list_bh = new List<BanHang_TraSua>();
        public static int TongSl = 0;
        public static int TongTien = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            var roCuw = this.hangHoaBindingSource.Current as HangHoa;
            int soLuong = Convert.ToInt32(this.sl_textBox.Text);

            
            if(roCuw != null)
            {
                if (soLuong > roCuw.Soluong || soLuong == 0)
                {
                    MessageBox.Show("Sản phẩm này đã hết. Bạn hãy chọn sản phẩm khác nhé!!!", "thông báo");
                }
                else
                {


                   

                    var bhts = new BanHang_TraSua();

                    bhts.TenHH = roCuw.TenHH;
                    bhts.SoLuong = soLuong;
                    bhts.TongTien = soLuong * Convert.ToInt32(roCuw.Gia);

                    // add ban hang tra sưax
                    list_bh.Add(bhts);
                    // tổng tiền
                    TongTien += bhts.TongTien;
                    this.TongTien_textbox.Text = TongTien.ToString();
                    
                    // loát bảng
                    this.banHang_TraSuaBindingSource.DataSource = null;
                    this.banHang_TraSuaBindingSource.DataSource = list_bh;

                    
                    // giảm số lượng
                    using (var repo = new HangHoa_Bussiness_Save())
                    {
                        roCuw.Soluong -= soLuong;
                        repo.item = roCuw;
                        repo.Execute();
                    }
                    this.button1_Click(null, null);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            using(var nv = new NhanVien_Select_All())
            {
                
                for(int i = 0; i < nv.Excute().Count; i ++ )
                {
                    this.comboBox1.Items.Add(nv.Excute()[i].TenNV);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
