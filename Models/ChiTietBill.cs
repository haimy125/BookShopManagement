using System;

namespace BookShopManagement.Models
{
    
    public partial class ChiTietBill
    {
        public string MsBill { get; set; }
        public string MsSach { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
