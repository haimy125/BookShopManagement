//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShopManagement.ModelTemp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.ChiTietBills = new HashSet<ChiTietBill>();
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.TonHangs = new HashSet<TonHang>();
        }
    
        public string MsSach { get; set; }
        public string TenSach { get; set; }
        public string Dvt { get; set; }
        public Nullable<double> GiaBan { get; set; }
        public string MoTa { get; set; }
        public string Hinh { get; set; }
        public Nullable<System.DateTime> NamXb { get; set; }
        public Nullable<int> SoTrang { get; set; }
        public string MsTg { get; set; }
        public string MsNxb { get; set; }
        public string MsLoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBill> ChiTietBills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual LoaiSach LoaiSach { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual TacGia TacGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TonHang> TonHangs { get; set; }
    }
}
