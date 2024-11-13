
using System;
using System.Collections.Generic;

namespace BookShopManagement.Models
{
    
    public partial class Sach
    {
        public Sach()
        {
            this.ChiTietBills = new HashSet<ChiTietBill>();
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.TonHangs = new HashSet<TonHang>();
        }
    
        public string MsSach { get; set; }
        public string TenSach { get; set; }
        public string Dvt { get; set; }
        public double GiaBan { get; set; }
        public string MoTa { get; set; }
        public string Hinh { get; set; }
        public DateTime NamXb { get; set; }
        public int SoTrang { get; set; }
        public string MsTg { get; set; }
        public string MsNxb { get; set; }
        public string MsLoai { get; set; }
    
        public ICollection<ChiTietBill> ChiTietBills { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public LoaiSach LoaiSach { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }
        public TacGia TacGia { get; set; }
        public ICollection<TonHang> TonHangs { get; set; }
    }
}
