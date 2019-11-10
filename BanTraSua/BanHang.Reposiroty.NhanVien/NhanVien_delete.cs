using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty.NhanVien
{
    public class NhanVien_delete:KetNoiSQL
    {
        public string MaNV { get; set; }
        public void Execute()
        {
            using(var conn= new SqlConnection(ConnectionString))
            {
                using(var cmd=conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete NhanVien where MaNV=@MaNV";
                    cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@MaNV",
                            Value = this.MaNV.sToSqlValues(),
                            SqlDbType = System.Data.SqlDbType.NVarChar
                        });
                    cmd.ExecuteNonQuery();//lưu kết quả truy vấn

                    conn.Close();
                }
            }
        }
    
    }
}
