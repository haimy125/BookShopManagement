
using System;
using System.Collections.Generic;
namespace BookShopManagement.Models
{

    public partial class TacGia
    {
        public TacGia()
        {
            this.Saches = new HashSet<Sach>();
        }

        public string MsTg { get; set; }
        public string TenTg { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }

        public ICollection<Sach> Saches { get; set; }
    }
}
