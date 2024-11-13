using System;
using System.Collections.Generic;

namespace BookShopManagement.Models
{
    public partial class LoaiSach
    {
        public LoaiSach()
        {
            this.Saches = new HashSet<Sach>();
        }
    
        public string MsLoai { get; set; }
        public string TenLoai { get; set; }
    
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
