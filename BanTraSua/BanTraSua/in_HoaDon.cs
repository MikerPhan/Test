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
    public partial class in_HoaDon : Form
    {
        public in_HoaDon()
        {
            InitializeComponent();
        }

        private void in_HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HoaDon_DataSet2.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.HoaDon_DataSet2.HoaDon);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
