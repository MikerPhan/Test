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
    public class HoaDon_insert:KetNoiSQL
    {
        public HoaDon item { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into HoaDon values(@MaHD,@MaKH,@MaNV,getdate())";

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
                        SqlDbType = System.Data.SqlDbType.Date
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
