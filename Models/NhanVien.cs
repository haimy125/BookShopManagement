using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class NhanVien
    {
        public string MsNv { get; set; }
        public string HoTen { get; set; }
        public string SoDt { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
