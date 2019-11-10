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
    public class DonHang_view:KetNoiSQL
    {
        public string MaDH { get; set; }
        public DonHang Execute()
        {
            DonHang data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Select* from DonHang where MaDH= @MaDH";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaDH",
                        Value = this.MaDH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new DonHang();
                            data.MaDH = Convert.ToString(reader["MaDH"].vSafe());
                            data.MaHH = Convert.ToString(reader["MaHH"].vSafe());
                            data.MaNCC = Convert.ToString(reader["MaNCC"].vSafe());
                            data.SoLuong= Convert.ToInt32(reader["SoLuong"].vSafe());
                            data.Gia = Convert.ToInt64(reader["Gia"].vSafe());
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
