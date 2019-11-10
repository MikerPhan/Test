using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;


namespace BanHang.Reposiroty_HangHoa
{
    public class HangHoa_view:KetNoiSQL
    {
        public string MaHH { get; set; }
        public HangHoa Execute()
        {
            HangHoa data= null;
            using(var conn= new SqlConnection(ConnectionString))
            {
                using(var cmd=conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText="Select* from HangHoa where MaHH= @MaHH";
                    cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName="@MaHH",
                            Value=this.MaHH.sToSqlValues(),
                            SqlDbType= System.Data.SqlDbType.NVarChar
                        });
                    using(var reader=cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            data=new HangHoa();
                            data.MaHH=Convert.ToString(reader["MaHH"].vSafe());
                            data.TenHH=Convert.ToString(reader["TenHH"].vSafe());
                            data.Soluong=Convert.ToInt32(reader["Soluong"].vSafe());
                            data.Gia=Convert.ToInt64(reader["Gia"].vSafe());
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
