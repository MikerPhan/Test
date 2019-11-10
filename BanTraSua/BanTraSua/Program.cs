using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanTraSua
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new QuanLiBanTraSua());
            //Application.Run(new FormHangHoa());
           // Application.Run(new FormBanHang());
            ///Application.Run(new .Report_HangHoa());
            ///
           // Application.Run(new in_HangHoa());
        }
    }
}
