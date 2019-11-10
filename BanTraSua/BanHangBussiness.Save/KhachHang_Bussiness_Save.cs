using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BanHang.Domain;
using BanHang.Library_01;
using BanHang.Reposiroty_KhachHang;

namespace BanHang_Bussiness_Save
{
    public class KhachHang_Bussiness_Save:KetNoiSQL
    {
        public KhachHang item { get; set; }
        public void Execute()
        {
            KhachHang check = null;
            using (var repo = new KhachHang_view())
            {
                repo.MaKH = item.MaKH;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại=>ta tiến hành update
            {
                using (var repo = new KhachHang_update())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
            else
            {
                // tiến hành insert
                using (var repo = new KhachHang_insert())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
        }
    }
}
