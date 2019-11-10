using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Reposiroty_NhanVien;
using BanHang.Domain;
using BanHang.Library_01;

namespace BanHang.Reposiroty_NhanVien
{
    public class NhanVien_Select_All:KetNoiSQL
    {
        public  List<NhanVien> Excute()
        {
            var list_nv = new List<NhanVien>();
            using(var conn= new SqlConnection(ConnectionString))
            {
                using(var cmd = conn.CreateCommand())
                {
                    conn.Open();//mở kết nối
                    cmd.CommandText = "select * from NhanVien";
                    using(SqlDataReader reader =cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            list_nv.Add(new NhanVien
                                {
                                    MaNV = Convert.ToString(reader["MaNV"].vSafe()),
                                    TenNV = Convert.ToString(reader["TenNV"].vSafe()),
                                    GioiTinh = Convert.ToString(reader["GioiTinh"].vSafe()),
                                    NamSinh = Convert.ToInt32(reader["NamSinh"].vSafe())

                                });
                        }
                    }

                    conn.Close();// đóng kết nối
                }
               
            }

            return list_nv;
        }
    }
}
