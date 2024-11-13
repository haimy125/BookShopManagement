using System;
using System.Collections.Generic;

namespace BookShopManagement.Models
{
    
    public partial class TonHang
    {
        public string MsNs { get; set; }
        public string MsSach { get; set; }
        public int SoLuongTon { get; set; }
    
        public NhaSach NhaSach { get; set; }
        public Sach Sach { get; set; }
    }
}
