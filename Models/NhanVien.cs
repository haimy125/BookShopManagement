using System;
using System.Collections.Generic;
namespace BookShopManagement.Models
{

    public partial class NhanVien
    {
        public NhanVien()
        {
            this.Bills = new HashSet<Bill>();
            this.HoaDons = new HashSet<HoaDon>();
        }

        public string MsNv { get; set; }
        public string HoTen { get; set; }
        public string SoDt { get; set; }

        public ICollection<Bill> Bills { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
