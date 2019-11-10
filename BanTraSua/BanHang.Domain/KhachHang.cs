using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
   public  class KhachHang
    {
       [DisplayName("Mã KH")]
       public string MaKH { get; set; }
       [DisplayName("Tên KH")]
       public string TenKH { get; set; }
       [DisplayName("Địa chỉ")]
       public string DiaChi { get; set; }
       [DisplayName("Số điện thoại")]
       public string SDT { get; set; }
    }
}
