using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BanHang.Domain
{
    public class NhanVien
    {
        [DisplayName("Tên NV")]
        public string TenNV { get; set; }

        [DisplayName("Mã NV")]
        public string MaNV { get; set; }

        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; }

        [DisplayName("Năm sinh")]
        public int NamSinh { get; set; }
    }
}
