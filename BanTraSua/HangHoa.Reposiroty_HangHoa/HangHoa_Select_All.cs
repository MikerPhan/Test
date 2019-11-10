using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Reposiroty_HangHoa;
using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_HangHoa
{
    public class HangHoa_Select_All:KetNoiSQL
    {
        public List<HangHoa> Excute()
        {


            var list_hh = new List<HangHoa>();
            using(var conn= new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                     conn.Open();//mở kết nối
                    cmd.CommandText = "select * from HangHoa";
                    using(SqlDataReader reader =cmd.ExecuteReader())
                    {
                         while(reader.Read())
                         {
                              list_hh.Add(new HangHoa{
                                 MaHH = Convert.ToString(reader["MaHH"].vSafe()),
                                 TenHH = Convert.ToString(reader["TenHH"].vSafe()),
                                 Gia = Convert.ToDouble(reader["Gia"].vSafe()),
                                 Soluong = Convert.ToInt32(reader["SoLuong"].vSafe()),
                              });

                              

                         }
                    }
                    conn.Close();//Đóng kết nối
                }
            }
            return list_hh;



        }

    


    }
}
