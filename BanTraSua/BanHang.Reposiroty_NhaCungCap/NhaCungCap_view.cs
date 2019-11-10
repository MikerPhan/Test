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
    public class NhaCungCap_view:KetNoiSQL
    {
        public string MaNCC { get; set; }
        public NhaCungCap Execute()
        {
            NhaCungCap data = null;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Select*from NhaCungCap where MaNCC=@MaNCC";
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MaNCC",
                        Value = this.MaNCC.sToSqlValues(),
                        SqlDbType = System.Data.SqlDbType.NVarChar
                    });

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data = new NhaCungCap();
                            data.MaNCC = Convert.ToString(reader["MaNCC"].vSafe());
                            data.TenNCC = Convert.ToString(reader["TenNCC"].vSafe());
                            data.HangHoaCC = Convert.ToString(reader["HangHoaCC"].vSafe());
                            data.ChatLuong = Convert.ToString(reader["Chatluong"].vSafe());
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
