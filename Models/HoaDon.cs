
using System;
using System.Collections.Generic;

namespace BookShopManagement.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            this.Bills = new HashSet<Bill>();
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    
        public string MsHd { get; set; }
        public DateTime NgayLap { get; set; }
        public string MsKh { get; set; }
        public string MsNv { get; set; }
        public double> TongTien { get; set; }
        public string DienGiai { get; set; }
        public int Loai { get; set; }
    
        public ICollection<Bill> Bills { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
