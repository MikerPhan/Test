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
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            if ((this.textBoxTenDN.Text == "HL") && (this.textBoxMK.Text == "123"))
                this.Close();
            else
            {
                MessageBox.Show("Không đúng tên người dùng/ mật khẩu!!!", "Thông báo");
                this.textBoxTenDN.Focus();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (traloi == DialogResult.OK)
                Application.Exit();

        }

        private void textBoxMK_TextChanged(object sender, EventArgs e)
        {
            textBoxMK.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTenDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
