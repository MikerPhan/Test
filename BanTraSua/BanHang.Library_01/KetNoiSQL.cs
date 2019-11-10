using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Library_01
{
    public class KetNoiSQL: IDisposable
    {
        public string ConnectionString;

        public KetNoiSQL()
        {
            //ConnectionString=@" Data Source=.;
            //                    Initial Catalog=BanTraSua;
            //                     Integrated Security=True";
            ConnectionString = @"Data Source=DESKTOP-GOM59QO\SQLEXPRESS;Initial Catalog=BanTraSua;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            

        }
        public void Dispose()
        {

        }
    }
}
