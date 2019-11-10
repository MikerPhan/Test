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
    public class HoaDon_delete:KetNoiSQL
    {
        public HoaDon item { get; set; }
        public string MaHD { get; set; }
        public void Execute()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete HoaDon where MaHD=@MaHD";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaHD",
                        Value = this.MaHD.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    cmd.ExecuteNonQuery();//lưu kết quả truy vấn

                    conn.Close();
                }
            }
        }


        //public HoaDon item { get; set; }

       // public HoaDon item { get; set; }
    }
}
