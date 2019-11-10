using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using BanHang.Reposiroty_KhachHang;
using BanHang.Library_01;
using BanHang.Domain;
namespace BanHang.Reposiroty_KhachHang
{
    public class KhachHang_Select_All: KetNoiSQL
    {
        public List<KhachHang> Excute()
        {
             var list_kh = new List<KhachHang>();
            using(var conn= new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();//mở kết nối
                    cmd.CommandText = "select * from KhachHang";
                    using(SqlDataReader reader =cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            list_kh.Add(new KhachHang {
                                MaKH = Convert.ToString(reader["MaKH"].vSafe()),
                                TenKH = Convert.ToString(reader["TenKH"].vSafe()),
                                DiaChi = Convert.ToString(reader["DiaChi"].vSafe()),
                                SDT = Convert.ToString(reader["SDT"].vSafe()),
                            });
                                 
                                 
                                 
                                 

                            }
                        }
                    conn.Close();//Đóng kết nối
                    }
                }
             return list_kh;
            }

        }
    
}
