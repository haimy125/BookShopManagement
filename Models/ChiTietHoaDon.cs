using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class ChiTietHoaDon
    {
        public string MsHd { get; set; }
        public string MsSach { get; set; }
        public int? SoLuong { get; set; }

        public HoaDon HoaDon { get; set; }
        public Sach Sach { get; set; }
    }
}
