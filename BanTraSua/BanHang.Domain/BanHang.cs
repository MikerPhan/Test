using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
    public class BanHang_TraSua
    {
        [DisplayName("Tên Hàng Hóa")]
        public String TenHH {get;set;}

        [DisplayName("Số Lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Tổng Tiền")]
        public int TongTien { get; set; }
    }
}
