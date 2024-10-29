using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class LoaiSach
    {
        public string MsLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<Sach> Sachs { get; set; }
    }
}
