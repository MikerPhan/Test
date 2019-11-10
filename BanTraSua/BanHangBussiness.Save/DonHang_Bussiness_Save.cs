using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BanHang.Library_01;
using BanHang.Domain;
using BanHang.Reposiroty_DonHang;

namespace BanHang_Bussiness_Save
{
    public class DonHang_Bussiness_Save:KetNoiSQL
    {
        public DonHang item { get; set; }
        public void Execute()
        {
            DonHang check = null;
            using (var repo = new DonHang_view())
            {
                repo.MaDH = item.MaDH;
                check = repo.Execute();
            }
            if (check != null) //đã tồn tại=>ta tiến hành update
            {
                using (var repo = new DonHang_update())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
            else
            {
                // tiến hành insert
                using (var repo = new DonHang_insert())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
        }
    }
}
