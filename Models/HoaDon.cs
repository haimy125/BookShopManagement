using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class HoaDon
    {
        public string MsHd { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MsKh { get; set; }
        public string MsNv { get; set; }
        public float? TongTien { get; set; }
        public string DienGiai { get; set; }
        public int? Loai { get; set; }

        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
