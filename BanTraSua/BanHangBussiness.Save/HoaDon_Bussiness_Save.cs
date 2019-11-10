using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BanHang.Library_01;
using BanHang.Domain;
using BanHang.Reposiroty_HoaDon;

namespace BanHang_Bussiness_Save
{
   public class HoaDon_Bussiness_Save:KetNoiSQL
    {
        public HoaDon item { get; set; }
        public void Execute()
        {
            HoaDon check = null;
            using (var repo = new HoaDon_view())
            {
                repo.MaHD = item.MaHD;
                check = repo.Execute();
            }
            if (check != null)//đã tồn tại ==> ta tiến hành update
            {
                using (var repo = new HoaDon_delete())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
            else
            {
                //tien hanh insert
                using (var repo = new HoaDon_insert())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
        }
    }
}
