using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class NhaSach
    {
        public string MsNs { get; set; }
        public string TenNs { get; set; }
        public string DiaChi { get; set; }
        public string KhuVuc { get; set; }
        public string SoDt { get; set; }
        public int? SucChua { get; set; }
        public int? ConTrong { get; set; }

        public ICollection<Sach> Sachs { get; set; }
    }
}
