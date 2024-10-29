using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class ChiTietBill
    {
        public string MsBill { get; set; }
        public string MsSach { get; set; }
        public int? SoLuong { get; set; }

        public Bill Bill { get; set; }
        public Sach Sach { get; set; }
    }
}
