using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Reposiroty_DonHang;
using BanHang.Domain;
using BanHang.Library_01;


namespace BanHang.Reposiroty_DonHang
{
    public class DonHang_Select_All:KetNoiSQL
    {
        public List<DonHang> Excute()
        {


            var list_dh = new List<DonHang>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();//mở kết nối
                    cmd.CommandText = "select * from DonHang";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list_dh.Add(new DonHang
                            {
                                MaDH=Convert.ToString(reader["MaDH"].vSafe()),
                                MaHH=Convert.ToString(reader["MaHH"].vSafe()),
                                MaNCC=Convert.ToString(reader["MaNCC"].vSafe()),
                                SoLuong=Convert.ToInt32(reader["SoLuong"].vSafe()),
                                Gia = Convert.ToDouble(reader["Gia"].vSafe()),
                                
                            });



                        }
                    }
                    conn.Close();//Đóng kết nối
                }
            }
            return list_dh;



        }

    }
}
