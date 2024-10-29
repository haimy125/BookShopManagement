using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class TacGia
    {
        public string MsTg { get; set; }
        public string TenTg { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }

        public ICollection<Sach> Sachs { get; set; }
    }
}
