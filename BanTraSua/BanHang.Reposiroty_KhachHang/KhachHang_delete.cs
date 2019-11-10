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
    public class KhachHang_delete:KetNoiSQL
    {
        public string MaKH { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete KhachHang where MaKH=@MaKH";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaKH",
                        Value = this.MaKH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();//lưu kết quả truy vấn

                    conn.Close();
                }
            }
        }
    
    }
}
