using System;
using System.Collections.Generic;
namespace BookShopManagement.Models
{

    public partial class NhaSach
    {
        public NhaSach()
        {
            this.TonHangs = new HashSet<TonHang>();
        }

        public string MsNs { get; set; }
        public string TenNs { get; set; }
        public string DiaChi { get; set; }
        public string KhuVuc { get; set; }
        public string SoDt { get; set; }
        public ICollection<TonHang> TonHangs { get; set; }
    }
}
