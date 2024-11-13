using System;
using System.Collections.Generic;
namespace BookShopManagement.Models
{
    
    public partial class Bill
    {
        public Bill()
        {
            this.ChiTietBills = new HashSet<ChiTietBill>();
        }
    
        public string MsBill { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string MsKh { get; set; }
        public string MsNv { get; set; }
        public string MsHd { get; set; }
        public Nullable<int> Loai { get; set; }
    
        public HoaDon HoaDon { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<ChiTietBill> ChiTietBills { get; set; }
    }
}
