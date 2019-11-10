using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BanHang.Library_01;
using BanHang.Domain;
using BanHang.Reposiroty_NhaCungCap;

namespace BanHang_Bussiness_Save
{
    public class NhaCungCap_Bussiness_Save:KetNoiSQL
    {
        public NhaCungCap item { get; set; }
        public void Execute()
        {
            NhaCungCap check = null;
            using (var repo = new NhaCungCap_view())
            {
                repo.MaNCC = item.MaNCC;
                check = repo.Execute();
            }
            if (check != null)//đã tồn tại ==> ta tiến hành update
            {
                using (var repo = new NhaCungCap_update())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
            else
            {
                //tien hanh insert
                using (var repo = new NhaCungCap_insert())
                {
                    repo.item = item;
                    repo.Execute();
                }
            }
        }
    }
}
