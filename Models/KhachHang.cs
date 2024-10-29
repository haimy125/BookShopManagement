using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class KhachHang
    {
        public string MsKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }
        public int Diem { get; set; }
        public string MsThue { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
