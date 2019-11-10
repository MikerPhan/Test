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
    public class HangHoa_update:KetNoiSQL
    {
        public HangHoa item { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = "insert into HangHoa values (@MaHH, @TenHH,@Soluong,@Gia)";
                    cmd.CommandText = " update HangHoa set MaHH=@MaHH, TenHH=@TenHH, Soluong=@Soluong,Gia=@Gia where MaHH=@MaHH";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaHH",
                        Value = item.MaHH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@TenHH",
                        Value = item.TenHH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Soluong",
                        Value = item.Soluong.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.Int
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Gia",
                        Value = item.Gia.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.Float
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
