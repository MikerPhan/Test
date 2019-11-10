
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
    public class NhanVien_update : KetNoiSQL
    {
       public NhanVien item { get; set; }
       public void Execute()
       {
           using (var conn = new SqlConnection(ConnectionString))
           {
               using (var cmd=conn.CreateCommand())
               {
                   conn.Open();
                   //cmd.CommandText = "insert into NhanVien values(@MaNV,@TenNV,@Gioitinh,@NamSinh)";
                   cmd.CommandText = "update  NhanVien set TenNV=@TenNV,GioiTinh=@GioiTinh,MaNV=@MaNV,NamSinh=@NamSinh where MaNV=@MaNV";

                   cmd.Parameters.Add(new SqlParameter
                       {
                           ParameterName = "@MaNV",
                           Value = item.MaNV.sToSqlValues(),
                           SqlDbType = System.Data.SqlDbType.NVarChar
                       });

                   cmd.Parameters.Add(new SqlParameter
                   {
                       ParameterName = "@TenNV",
                       Value = item.TenNV.sToSqlValues(),
                       SqlDbType = System.Data.SqlDbType.NVarChar
                   });
                   cmd.Parameters.Add(new SqlParameter
                   {
                       ParameterName = "@GioiTinh",
                       Value = item.GioiTinh.sToSqlValues(),
                       SqlDbType = System.Data.SqlDbType.NVarChar
                   });
                   cmd.Parameters.Add(new SqlParameter
                   {
                       ParameterName = "@NamSinh",
                       Value = item.NamSinh.sToSqlValues(),
                       SqlDbType = System.Data.SqlDbType.Int
                   });
                   cmd.ExecuteNonQuery();
                   conn.Close();
               }
           }
       }
    }
}
