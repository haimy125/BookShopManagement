using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Models
{
    internal class Sach
    {
        public string MsSach { get; set; }
        public string TenSach { get; set; }
        public string Dvt { get; set; }
        public float? GiaBan { get; set; }
        public string MoTa { get; set; }
        public string Hinh { get; set; }
        public DateTime? NamXb { get; set; }
        public int? SoTrang { get; set; }

        public string MsTg { get; set; }
        public string MsNxb { get; set; }
        public string MsLoai { get; set; }

        public NhaXuatBan NhaXuatBan { get; set; }
        public LoaiSach LoaiSach { get; set; }
        public TacGia TacGia { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public ICollection<ChiTietBill> ChiTietBills { get; set; }
    }
}
