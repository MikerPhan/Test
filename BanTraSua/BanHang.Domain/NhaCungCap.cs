using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
    public class NhaCungCap
    {
        [DisplayName("Mã NCC")]
        public string MaNCC { get; set; }
        [DisplayName("Tên NCC")]
        public string TenNCC { get; set; }
        [DisplayName("Hàng Hóa CC")]
        public string HangHoaCC { get; set; }
        [DisplayName("Chất lượng")]
        public string ChatLuong { get; set; }

       // public int Chatluong { get; set; }
    }
}
