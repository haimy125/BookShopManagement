using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagement.Data;
using BookShopManagement.Models;
using BookShopManagement.Utilities;

namespace BookShopManagement.Services
{
    internal class QueryService
    {

        // 1. Lấy danh sách khách hàng
        public static void getDachSachKhachHang()
        {
            var khachHangs = DataInitializer.KhachHangs;

            TablePrinter.PrintTable("Danh sách khách hàng", new[] { "Mã khách hàng", "Tên", "Địa chỉ", "Số điện thoại", "Mã thuế", "Điểm" }, khachHangs,
                kh => kh.MsKh,     // Selector cho "Mã khách hàng"
                kh => kh.TenKh,    // Selector cho "Tên"
                kh => kh.DiaChi,   // Selector cho "Địa chỉ"
                kh => kh.SoDt,     // Selector cho "Số điện thoại"
                kh => kh.MsThue,   // Selector cho "Mã thuế"
                kh => kh.Diem      // Selector cho "Điểm");
             );   
        }

        // 2. Lấy danh sách sách có giá bán lớn hơn 250.000
        public static void getSachCoGiaCao()
        {
            var sachGiaCao = DataInitializer.Sachs.Where(s => s.GiaBan > 250000).ToList();

            TablePrinter.PrintTable(
                "Danh sách sách có giá lớn hơn 250.000",
                new[]
                {
                "Mã số Sách", "Tên sách", "Dvt", "Giá Bán", "Mô tả", "Hình", "Năm XB", "Số trang"
                        },
                        sachGiaCao,
                        s => s.MsSach,    // Selector cho "Mã số Sách"
                        s => s.TenSach,   // Selector cho "Tên sách"
                        s => s.Dvt,       // Selector cho "Dvt"
                        s => s.GiaBan,    // Selector cho "GiaBan"
                        s => s.MoTa,      // Selector cho "Mô tả"
                        s => s.Hinh,      // Selector cho "Hình"
                        s => s.NamXb,     // Selector cho "Năm XB"
                        s => s.SoTrang   // Selector cho "Số trang"
             );
        }

        // 3. Lấy tên nhân viên theo mã nhân viên
        public static void getNhanVienTheoMa()
        {
            Console.Write("Nhập mã nhân viên: ");
            string maNV = Console.ReadLine();

            var nhanVien = DataInitializer.NhanViens.FirstOrDefault(nv => nv.MsNv == maNV);
            if(nhanVien != null)
            {
                // Tạo danh sách chứa nhân viên tìm được
                var danhSachNhanVien = new List<NhanVien> { nhanVien };

                TablePrinter.PrintTable(
                    "Nhân Viên",
                    new string[] { "Mã NV", "Họ Tên", "Số điện thoại" },
                    danhSachNhanVien,
                    nv => nv.MsNv,
                    nv => nv.HoTen,
                    nv => nv.SoDt
                 );
            } else
            {
                Console.WriteLine("Không tìm thấy nhân viên có mã " + maNV);
            }
        }

        // 4. Tính tổng tiền của hóa đơn
        public static void tongTienHoaDon()
        {
            var tongTien = DataInitializer.HoaDons.Sum(hd => hd.TongTien) ?? 0;
        }

        //// 5. Lấy danh sách sách theo loại
        //var sachTheoLoai = DataInitializer.Sachs.Where(s => s.MsLoai == "LOAI001").ToList();

        //// 6. Lấy danh sách hóa đơn theo khách hàng
        //var hoaDonsKhachHang = DataInitializer.HoaDons.Where(hd => hd.MsKh == "KH001").ToList();

        //// 7. Lấy danh sách chi tiết hóa đơn của một hóa đơn cụ thể
        //var chiTietHD = DataInitializer.ChiTietHoaDons.Where(ct => ct.MsHd == "HD001").ToList();

        //// 8. Lấy thông tin sách theo tên
        //var sachTheoTen = DataInitializer.Sachs.FirstOrDefault(s => s.TenSach == "C# Programming");

        //// 9. Lấy danh sách nhân viên
        //var danhSachNV = DataInitializer.NhanViens.ToList();

        //// 10. Lấy danh sách bill theo khách hàng
        //var billsKhachHang = DataInitializer.Bills.Where(b => b.MsKh == "KH001").ToList();

    }
}
