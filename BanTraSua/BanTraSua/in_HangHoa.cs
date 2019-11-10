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
    public partial class in_HangHoa : Form
    {
        public in_HangHoa()
        {
            InitializeComponent();
        }

        private void in_HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.HangHoa' table. You can move, or remove it, as needed.
            this.HangHoaTableAdapter.Fill(this.DataSet1.HangHoa);
            this.reportViewer1.RefreshReport();
        }
    }
}
