using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using BanHang.Reposiroty_NhaCungCap;
using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_NhaCungCap
{
    public class NhaCungCap_Select_All : KetNoiSQL
    {
        public List<NhaCungCap> Excute()
        {
            var list_ncc = new List<NhaCungCap>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();//mở kết nối
                    cmd.CommandText = "select * from NhaCungCap";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list_ncc.Add(new NhaCungCap
                            {
                                MaNCC = Convert.ToString(reader["MaNCC"].vSafe()),
                                TenNCC = Convert.ToString(reader["TenNCC"].vSafe()),
                                ChatLuong = Convert.ToString(reader["ChatLuong"].vSafe()),
                                HangHoaCC = Convert.ToString(reader["HangHoaCC"].vSafe()),
                            });
                        }
                    }
                    conn.Close();//Đóng kết nối

                }
            }
            return list_ncc;

        }
    }
}
