using System;
using System.Collections.Generic;
using System.Globalization;
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

            if (khachHangs != null && khachHangs.Any())
            {
                TablePrinter.PrintTable(
                    "Danh sách khách hàng",
                    new[] { "Mã khách hàng", "Tên", "Địa chỉ", "Số điện thoại", "Mã thuế", "Điểm" },
                    khachHangs,
                    kh => kh.MsKh,      // Selector cho "Mã khách hàng"
                    kh => kh.TenKh,     // Selector cho "Tên"
                    kh => kh.DiaChi,    // Selector cho "Địa chỉ"
                    kh => kh.SoDt,      // Selector cho "Số điện thoại"
                    kh => kh.MsThue,    // Selector cho "Mã thuế"
                    kh => kh.Diem       // Selector cho "Điểm"
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy dữ liệu khách hàng");
            }
        }

        // 2. Lấy danh sách sách có giá bán lớn hơn 250.000
        public static void getSachCoGiaCao()
        {
            var sachGiaCao = DataInitializer.Sachs
                .Where(s => s.GiaBan.HasValue && s.GiaBan > 250000) // Kiểm tra nếu `GiaBan` là nullable
                .ToList();

            if (sachGiaCao.Any())
            {
                TablePrinter.PrintTable(
                    "Danh sách sách có giá lớn hơn 250.000",
                    new[] { "Mã số Sách", "Tên sách", "Dvt", "Giá Bán", "Mô tả", "Hình", "Năm XB", "Số trang" },
                    sachGiaCao,
                    s => s.MsSach,
                    s => s.TenSach,
                    s => s.Dvt,
                    s => s.GiaBan,
                    s => s.MoTa,
                    s => s.Hinh,
                    s => s.NamXb,
                    s => s.SoTrang
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách nào có giá lớn hơn 250.000");
            }
        }

        // 3. Lấy tên nhân viên theo mã nhân viên
        public static void getNhanVienTheoMa()
        {
            Console.Write("Nhập mã nhân viên: ");
            string maNV = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(maNV))
            {
                Console.WriteLine("Mã nhân viên không được để trống.");
                return;
            }

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

        // 4. Lấy danh sách hóa đơn theo tổng tiền lớn hơn một giá trị cụ thể
        public static void getHoaDonTheoTongTien()
        {
            Console.Write("Nhập vào tổng tiền tối thiểu: ");
            if (decimal.TryParse(Console.ReadLine()?.Trim(), out decimal tongTienMin))
            {
                var hoaDon = DataInitializer.HoaDons
                    .Where(hd => hd.TongTien.HasValue && (decimal)hd.TongTien.Value >= tongTienMin)
                    .ToList();

                if (hoaDon.Any())
                {
                    TablePrinter.PrintTable(
                        "Danh sách hóa đơn theo tổng tiền",
                        new[] { "Mã hóa đơn", "Ngày lập", "Tổng tiền" },
                        hoaDon,
                        hd => hd.MsHd,
                        hd => hd.NgayLap.HasValue ? hd.NgayLap.Value.ToString("dd/MM/yyyy") : "N/A",
                        hd => hd.TongTien.HasValue ? hd.TongTien.Value.ToString("N0") : "N/A"
                    );
                }
                else
                {
                    Console.WriteLine("Không tìm thấy hóa đơn nào có tổng tiền lớn hơn hoặc bằng " + tongTienMin);
                }
            }
            else
            {
                Console.WriteLine("Tổng tiền nhập không hợp lệ.");
            }
        }

        // 5. Lấy danh sách sách theo loại
        public static void getSachTheoLoai()
        {
            Console.Write("Nhập mã loại sách: ");
            string maSach = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(maSach))
            {
                Console.WriteLine("Mã loại sách không hợp lệ.");
                return;
            }

            if (DataInitializer.Sachs == null || !DataInitializer.Sachs.Any())
            {
                Console.WriteLine("Dữ liệu sách chưa được khởi tạo.");
                return;
            }

            var sachTheoLoai = DataInitializer.Sachs.Where(s => s.MsLoai.Equals(maSach)).ToList();

            if (sachTheoLoai.Any())
            {
                TablePrinter.PrintTable(
                    "Danh sách sách",
                    new string[] { "Mã số sách", "Tên sách", "Dvt", "Giá bán", "Mô tả", "Hình", "Năm XB", "Số trang" },
                    sachTheoLoai,
                    s => s.MsSach,    // Selector cho "Mã số Sách"
                    s => s.TenSach,   // Selector cho "Tên sách"
                    s => s.Dvt,       // Selector cho "Dvt"
                    s => s.GiaBan,    // Selector cho "GiaBan"
                    s => s.MoTa,      // Selector cho "Mô tả"
                    s => s.Hinh,      // Selector cho "Hình"
                    s => s.NamXb,     // Selector cho "Năm XB"
                    s => s.SoTrang    // Selector cho "Số trang"
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách có mã " + maSach);
            }
        }

        // 6. Lấy danh sách hóa đơn theo khách hàng
        public static void getDsHdTheoKh()
        {
            Console.WriteLine("Nhập mã khách hàng: ");
            string maKH = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                Console.WriteLine("Mã khách hàng không được để trống.");
                return;
            }

            var hoaDon = DataInitializer.HoaDons.Where(h => h.MsKh.Equals(maKH)).ToList();

            if (hoaDon.Any())
            {
                TablePrinter.PrintTable(
                    "Danh sách hóa đơn",
                    new string[] { "Mã hóa đơn", "Ngày lập", "Mã khách hàng", "Mã nhân viên", "Tổng tiền", "Diễn giải", "Loại" },
                    hoaDon,
                    h => h.MsHd,        // Selector cho "Mã hóa đơn"
                    h => h.NgayLap,     // Selector cho "Ngày lập"
                    h => h.MsKh,        // Selector cho "Mã khách hàng"
                    h => h.MsNv,        // Selector cho "Mã nhân viên"
                    h => h.TongTien,    // Selector cho "Tổng tiền"
                    h => h.DienGiai,    // Selector cho "Diễn giải"
                    h => h.Loai         // Selector cho "Loại"
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách hàng có mã " + maKH);
            }
        }

        // 7. Lấy danh sách chi tiết hóa đơn của một hóa đơn cụ thể
        public static void getChiTietHoaDon()
        {
            Console.Write("Nhập mã hóa đơn: ");
            string maHD = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(maHD))
            {
                Console.WriteLine("Mã hóa đơn không được để trống.");
                return;
            }

            var cthd = DataInitializer.ChiTietHoaDons.Where(ct => ct.MsHd?.Equals(maHD, StringComparison.OrdinalIgnoreCase) == true).ToList();

            if (cthd.Any())
            {
                TablePrinter.PrintTable(
                    "Chi tiết hóa đơn",
                    new string[] { "Mã hóa đơn", "Mã sách", "Số lượng" },
                    cthd,
                    h => h.MsHd,      
                    h => h.MsSach,    
                    h => h.SoLuong   
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy hóa đơn có mã " + maHD);
            }

        }

        // 8. Lấy thông tin sách theo tên
        public static void getSachTheoTen()
        {
            Console.Write("Nhập tên sách: ");
            string tenSach = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(tenSach))
            {
                Console.WriteLine("Tên sách không được để trống.");
                return;
            }

            var sachTheoTen = DataInitializer.Sachs
                .Where(s => s.TenSach.IndexOf(tenSach, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (sachTheoTen.Any())
            {
                TablePrinter.PrintTable(
                    "Danh sách sách theo tên",
                    new[] { "Mã số Sách", "Tên sách", "ĐVT", "Giá Bán", "Mô tả", "Hình", "Năm XB", "Số trang" },
                    sachTheoTen,
                    s => s.MsSach,    // Selector cho "Mã số Sách"
                    s => s.TenSach,   // Selector cho "Tên sách"
                    s => s.Dvt,       // Selector cho "ĐVT"
                    s => s.GiaBan,    // Selector cho "Giá Bán"
                    s => s.MoTa,      // Selector cho "Mô tả"
                    s => s.Hinh,      // Selector cho "Hình"
                    s => s.NamXb,     // Selector cho "Năm XB"
                    s => s.SoTrang    // Selector cho "Số trang"
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách nào có tên " + tenSach);
            }
        }

        // 9. Lấy danh sách hóa đơn theo ngày lập
        public static void getHoaDonTheoNgay()
        {
            Console.Write("Nhập ngày lập hóa đơn (dd/MM/yyyy): ");
            string ngayLap = Console.ReadLine()?.Trim();

            // Kiểm tra xem định dạng ngày có hợp lệ không
            if (DateTime.TryParseExact(ngayLap, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayLapHD))
            {
                var hoaDonTheoNgay = DataInitializer.HoaDons.Where(hd => hd.NgayLap.HasValue && hd.NgayLap.Value.Date == ngayLapHD.Date).ToList(); // Sử dụng HasValue và .Value.Date để so sánh

                if (hoaDonTheoNgay.Any())
                {
                    TablePrinter.PrintTable(
                        "Danh sách hóa đơn theo ngày lập",
                        new[] { "Mã hóa đơn", "Ngày lập", "Mã khách hàng", "Mã nhân viên", "Tổng tiền", "Diễn giải", "Loại" },
                        hoaDonTheoNgay,
                        hd => hd.MsHd,      // Selector cho "Mã hóa đơn"
                        hd => hd.NgayLap.HasValue ? hd.NgayLap.Value.ToString("dd/MM/yyyy") : "N/A",  // Selector cho "Ngày lập" với định dạng hoặc "N/A"
                        hd => hd.MsKh,      // Selector cho "Mã khách hàng"
                        hd => hd.MsNv,      // Selector cho "Mã nhân viên"
                        hd => hd.TongTien,  // Selector cho "Tổng tiền"
                        hd => hd.DienGiai,  // Selector cho "Diễn giải"
                        hd => hd.Loai       // Selector cho "Loại"
                    );
                }
                else
                {
                    Console.WriteLine("Không tìm thấy hóa đơn nào lập vào ngày " + ngayLapHD.ToString("dd/MM/yyyy"));
                }
            } else
            {
                Console.WriteLine("Ngày nhập không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
            }
        }

        // 10. Lấy danh sách sách có mô tả chứa từ khóa
        public static void getSachTheoMoTa()
        {
            Console.Write("Nhập từ khóa trong mô tả sách: ");
            string tuKhoa = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                Console.WriteLine("Từ khóa không được để trống.");
                return;
            }

            var sachTheoMoTa = DataInitializer.Sachs
                .Where(s => s.MoTa?.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (sachTheoMoTa.Any())
            {
                TablePrinter.PrintTable(
                    "Danh sách sách theo mô tả",
                    new[] { "Mã số Sách", "Tên sách", "ĐVT", "Giá Bán", "Mô tả", "Hình", "Năm XB", "Số trang" },
                    sachTheoMoTa,
                    s => s.MsSach,    // Selector cho "Mã số Sách"
                    s => s.TenSach,   // Selector cho "Tên sách"
                    s => s.Dvt,       // Selector cho "ĐVT"
                    s => s.GiaBan,    // Selector cho "Giá Bán"
                    s => s.MoTa,      // Selector cho "Mô tả"
                    s => s.Hinh,      // Selector cho "Hình"
                    s => s.NamXb,     // Selector cho "Năm XB"
                    s => s.SoTrang    // Selector cho "Số trang"
                );
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách nào có mô tả chứa từ khóa " + tuKhoa);
            }
        }
    }
}
