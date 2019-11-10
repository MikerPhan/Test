using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using BanHang.Domain;
using BanHang.Library_01;


namespace BanHang.Reposiroty_NhanVien
{
    public class NhanVien_view:KetNoiSQL
    {
        public string MaNV { get; set; }
        public NhanVien Execute()
        {
            NhanVien data = null;
            using(var conn=new SqlConnection(ConnectionString))
            {
                using(var cmd=conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Select*from NhanVien where MaNV=@MaNV";
                    cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@MaNV",
                            Value = this.MaNV.sToSqlValues(),
                            SqlDbType = System.Data.SqlDbType.NVarChar
                        });

                    using(var reader=cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            data = new NhanVien();
                            data.MaNV = Convert.ToString(reader["MaNV"].vSafe());
                            data.TenNV = Convert.ToString(reader["TenNV"].vSafe());
                            data.GioiTinh = Convert.ToString(reader["GioiTinh"].vSafe());
                            data.NamSinh = Convert.ToInt32(reader["NamSinh"].vSafe());
                        }
                    }
                    conn.Close();
                }
            }
            return data;
        }
    }
}
