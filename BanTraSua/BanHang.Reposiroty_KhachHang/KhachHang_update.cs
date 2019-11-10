using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_KhachHang
{
    public class KhachHang_update:KetNoiSQL
    {
        public KhachHang item { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = "insert into KhachHang values(@MaKH,@TenKH,@Diachi,@SDT)";
                    cmd.CommandText = "update KhachHang set MaKH=@MaKH,TenKH=@TenKH,Diachi=@Diachi,SDT=@SDT";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaKH",
                        Value = item.MaKH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });

                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@TenKH",
                        Value = item.TenKH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Diachi",
                        Value = item.DiaChi.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@SDT",
                        Value = item.SDT.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
