using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
    public class DonHang
    {
        [DisplayName("Mã DH")]
        public string MaDH { get; set; }
        [DisplayName("Mã HH")]
        public string MaHH { get; set; }
        [DisplayName("Mã NCC")]
        public string MaNCC { get; set; }
        [DisplayName("Số Lượng")]
        public int SoLuong { get; set; }
        [DisplayName("Gia")]
        public double Gia { get; set; }
    }
}
