using System;
using System.Collections.Generic;

namespace BookShopManagement.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            this.Bills = new HashSet<Bill>();
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public string MsKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }
        public int Diem { get; set; }
        public string MsThue { get; set; }
    
        public ICollection<Bill> Bills { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
