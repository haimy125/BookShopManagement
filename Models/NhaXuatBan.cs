using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class NhaXuatBan
    {
        public string MsNxb { get; set; }
        public string TenNxb { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }

        public ICollection<Sach> Sachs { get; set; }
    }
}
