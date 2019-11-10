using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Reposiroty_HoaDon;
using BanHang.Domain;
using BanHang.Library_01;



namespace BanHang.Reposiroty_HoaDon
{
    public class HoaDon_Select_All:KetNoiSQL
    {
        public List<HoaDon> Excute()
        {
            var list_hd = new List<HoaDon>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();//mở kết nối
                    cmd.CommandText = "select * from HoaDon";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                         while (reader.Read())
                         {
                             list_hd.Add(new HoaDon
                             {
                                 MaHD = Convert.ToString(reader["MaHD"].vSafe()),
                                 MaKH = Convert.ToString(reader["MaKH"].vSafe()),
                                 MaNV = Convert.ToString(reader["MaNV"].vSafe()),
                                 NgayLapHD = Convert.ToDateTime(reader["NgayLapHD"].vSafe()),
                             });
                         }
                    }
                    conn.Close();//đóng kết nối
                }
            }
            return list_hd;
        }
    }
}
