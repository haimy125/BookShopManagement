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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.ChiTietBills = new HashSet<ChiTietBill>();
        }
    
        public string MsBill { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string MsKh { get; set; }
        public string MsNv { get; set; }
        public string MsHd { get; set; }
        public Nullable<int> Loai { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBill> ChiTietBills { get; set; }
    }
}
