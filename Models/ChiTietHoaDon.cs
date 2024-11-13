using System;

namespace BookShopManagement.Models
{
    public partial class ChiTietHoaDon
    {
        public string MsHd { get; set; }
        public string MsSach { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual Sach Sach { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
