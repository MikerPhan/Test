using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BanHang.Library_01;
using BanHang.Domain;
using BanHang.Reposiroty_HangHoa;


namespace BanHang_Bussiness_Save
{
    public class HangHoa_Bussiness_Save:KetNoiSQL
    {
        public HangHoa item { get; set; }
        public void Execute()
        {
            HangHoa check = null;
            using(var repo=new HangHoa_view())
            {
                repo.MaHH = item.MaHH;
                check = repo.Execute();
            }
            if(check!=null) //đã tồn tại=>ta tiến hành update
            {
                using (var repo=new HangHoa_update())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
            else
            {
                // tiến hành insert
                using(var repo=new HangHoa_insert())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
        }
    }
}
