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
   public class HoaDon_view:KetNoiSQL
    {
        public string MaHD { get; set; }
        public HoaDon Execute()
        {
            HoaDon data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Select*from HoaDon where MaHD=@MaHD";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaHD",
                        Value = this.MaHD.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            data = new HoaDon();
                            data.MaHD = Convert.ToString(reader["MaHD"].vSafe());
                            data.MaKH = Convert.ToString(reader["MaKH"].vSafe());
                            data.MaNV = Convert.ToString(reader["MaNV"].vSafe());
                            data.NgayLapHD = Convert.ToDateTime(reader["NgaylapHD"].vSafe());
                            
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
