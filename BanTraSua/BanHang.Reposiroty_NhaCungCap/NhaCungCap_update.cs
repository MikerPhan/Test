using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_NhaCungCap
{
    public class NhaCungCap_update:KetNoiSQL
    {
        public NhaCungCap item { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = "insert into NhaCungCap values(@MaNCC,@TenNCC,@HangHoaCC,@Chatluong)";
                    cmd.CommandText = "update NhaCungCap set MaNCC=@MaNCC, TenNCC=@TenNCC, HangHoaCC=@HangHoaCC, Chatluong=@Chatluong";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaNCC",
                        Value = item.MaNCC.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });

                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@TenNCC",
                        Value = item.TenNCC.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@HangHoaCC",
                        Value = item.HangHoaCC.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Chatluong",
                        Value = item.ChatLuong.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
