using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_HoaDon
{
    public class HoaDon_update:KetNoiSQL
    {
        public HoaDon item { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                   // cmd.CommandText = "insert into HoaDon values(@MaHD,@MaKH,@MaNV,@NgaylapHD)";
                    cmd.CommandText = "update HoaDon set MaHD=@MaHD, MaKH=@MaKH, MaNV=@MaNV, NgaylapHD=@NgaylapHD";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaHD",
                        Value = item.MaHD.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });

                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaKH",
                        Value = item.MaKH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaNV",
                        Value = item.MaNV.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@NgaylapHD",
                        Value = item.NgayLapHD.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.DateTime
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
