using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_DonHang
{
    public class DonHang_update:KetNoiSQL
    {
        public DonHang item { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = "insert into HangHoa values (@MaHH, @TenHH,@Soluong,@Gia)";
                    cmd.CommandText = " update DonHang set MaDH=@MaDH, MaHH=@MaHH,MaNCC=@MaNCC, SoLuong=@SoLuong,Gia=@Gia where MaDH=@MaDH";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaDH",
                        Value = item.MaDH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaHH",
                        Value = item.MaHH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaNCC",
                        Value = item.MaNCC.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@SoLuong",
                        Value = item.SoLuong.sToSqlValues(),
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
