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
    public class KhachHang_view:KetNoiSQL
    {
        public string MaKH { get; set; }
        public KhachHang Execute()
        {
            KhachHang data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Select* from KhachHang where MaKH= @MaKH";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaKH",
                        Value = this.MaKH.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new KhachHang();
                            data.MaKH = Convert.ToString(reader["MaKH"].vSafe());
                            data.TenKH = Convert.ToString(reader["TenKH"].vSafe());
                            data.DiaChi = Convert.ToString(reader["Diachi"].vSafe());
                            data.SDT = Convert.ToString(reader["SDT"].vSafe());
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
