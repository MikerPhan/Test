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
            ConnectionString = @"Server=myServerAddress;
                                Database=myDataBase;
                                User ID=myUsername;
                                Password=myPassword;
                                Trusted_Connection=True";

        }
        public void Dispose()
        {

        }
    }
}
