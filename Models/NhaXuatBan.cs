using System;
using System.Collections.Generic;
namespace BookShopManagement.Models
{
    
    public partial class NhaXuatBan
    {
        public NhaXuatBan()
        {
            this.Saches = new HashSet<Sach>();
        }
    
        public string MsNxb { get; set; }
        public string TenNxb { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }
    
        public ICollection<Sach> Saches { get; set; }
    }
}
