using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
    public class HoaDon
    {
        
        [DisplayName("Mã HD")]
        public string MaHD { get; set; }

        [DisplayName("Mã KH")]
        public string MaKH { get; set; }

        [DisplayName("Mã NV")]
        public string MaNV { get; set; }

        [DisplayName("Ngày Lập HD")]
        public DateTime NgayLapHD { get; set; }
        
    }
}
