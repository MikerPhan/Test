using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BanHang.Library_01;
using BanHang.Domain;
using BanHang.Reposiroty_NhanVien;

namespace BanHang_Bussines_Save
{
    public class NhanVien_Bussiness_Save:KetNoiSQL
    {
        public NhanVien item { get; set; }
        public void Execute()
        {
            NhanVien check = null;
            using (var repo= new NhanVien_view())
            {
                repo.MaNV = item.MaNV;
                check = repo.Execute();
            }
            if(check != null)//đã tồn tại ==> ta tiến hành update
            {
                using(var repo=new NhanVien_update())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
            else
            {
                //tien hanh ínert
                using(var repo =new NhanVien_insert())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
        }
    }
}
