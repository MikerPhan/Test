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
    public class NhaCungCap_delete:KetNoiSQL
    {
        public string MaNCC { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete NhaCungCap where MaNCC=@MaNCC";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaNCC",
                        Value = this.MaNCC.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();//lưu kết quả truy vấn

                    conn.Close();
                }
            }
        }
    
    }
}
