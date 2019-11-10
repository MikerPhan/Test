using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
    public class HangHoa
    {
        [DisplayName("Mã HH")]
        public string MaHH { get; set; }
        [DisplayName("Tên HH")]
        public string TenHH { get; set; }
        [DisplayName("Số lượng")]
        public int Soluong { get; set; }
        [DisplayName("Giá")]
        public double Gia { get; set; }





    }
}
