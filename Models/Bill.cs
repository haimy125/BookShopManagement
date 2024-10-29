using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class Bill
    {
        public string MsBill { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MsKh { get; set; }
        public string MsNv { get; set; }
        public string MsHd { get; set; }
        public int? Loai { get; set; }

        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public HoaDon HoaDon { get; set; }
        public ICollection<ChiTietBill> ChiTietBills { get; set; }
    }
}
