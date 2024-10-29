using BookShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Data
{
    internal class DataInitializer
    {
        public static List<KhachHang> KhachHangs { get; private set; }
        public static List<NhanVien> NhanViens { get; private set; }
        public static List<HoaDon> HoaDons { get; private set; }
        public static List<ChiTietHoaDon> ChiTietHoaDons { get; private set; }
        public static List<Bill> Bills { get; private set; }
        public static List<ChiTietBill> ChiTietBills { get; private set; }
        public static List<Sach> Sachs { get; private set; }
        public static List<NhaSach> NhaSachs { get; private set; }
        public static List<NhaXuatBan> NhaXuatBans { get; private set; }
        public static List<TacGia> TacGias { get; private set; }
        public static List<LoaiSach> LoaiSachs { get; private set; }

        static DataInitializer()
        {
            KhachHangs = new List<KhachHang>
            {
                new KhachHang { MsKh = "KH001", TenKh = "Nguyen Van A", DiaChi = "123 Đường ABC", SoDt = "0123456789", MsThue = "123456789", Diem = 10 },
                new KhachHang { MsKh = "KH002", TenKh = "Tran Thi B", DiaChi = "456 Đường DEF", SoDt = "0987654321", MsThue = "987654321", Diem = 5 },
                new KhachHang { MsKh = "KH003", TenKh = "Pham Van C", DiaChi = "789 Đường GHI", SoDt = "0988123456", MsThue = "1122334455", Diem = 8 },
                new KhachHang { MsKh = "KH004", TenKh = "Le Thi D", DiaChi = "321 Đường JKL", SoDt = "0765432189", MsThue = "2233445566", Diem = 15 },
                new KhachHang { MsKh = "KH005", TenKh = "Hoang Van E", DiaChi = "159 Đường MNO", SoDt = "0909876543", MsThue = "3344556677", Diem = 7 },
                new KhachHang { MsKh = "KH006", TenKh = "Do Thi F", DiaChi = "753 Đường PQR", SoDt = "0912233445", MsThue = "4455667788", Diem = 12 },
                new KhachHang { MsKh = "KH007", TenKh = "Bui Van G", DiaChi = "951 Đường STU", SoDt = "0934567890", MsThue = "5566778899", Diem = 4 },
                new KhachHang { MsKh = "KH008", TenKh = "Dang Thi H", DiaChi = "852 Đường VWX", SoDt = "0912345678", MsThue = "6677889900", Diem = 9 },
                new KhachHang { MsKh = "KH009", TenKh = "Ngo Van I", DiaChi = "753 Đường YZ", SoDt = "0965432187", MsThue = "7788990011", Diem = 11 },
                new KhachHang { MsKh = "KH010", TenKh = "Truong Thi K", DiaChi = "951 Đường ABC", SoDt = "0933456781", MsThue = "8899001122", Diem = 6 }
            };

            NhanViens = new List<NhanVien>
            {
                new NhanVien { MsNv = "NV001", HoTen = "Le Van C", SoDt = "0112233445" },
                new NhanVien { MsNv = "NV002", HoTen = "Nguyen Thi D", SoDt = "0667788990" },
                new NhanVien { MsNv = "NV003", HoTen = "Pham Van E", SoDt = "0889900112" },
                new NhanVien { MsNv = "NV004", HoTen = "Bui Thi F", SoDt = "0771234567" },
                new NhanVien { MsNv = "NV005", HoTen = "Dang Van G", SoDt = "0912345678" },
                new NhanVien { MsNv = "NV006", HoTen = "Tran Thi H", SoDt = "0933456789" },
                new NhanVien { MsNv = "NV007", HoTen = "Hoang Van I", SoDt = "0812345670" },
                new NhanVien { MsNv = "NV008", HoTen = "Ngo Thi K", SoDt = "0865432109" },
                new NhanVien { MsNv = "NV009", HoTen = "Do Van L", SoDt = "0943210987" },
                new NhanVien { MsNv = "NV010", HoTen = "Truong Thi M", SoDt = "0832109876" }
            };

            Sachs = new List<Sach>
            {
                new Sach { MsSach = "S001", TenSach = "C# Programming", Dvt = "Cuốn", GiaBan = 250000, MoTa = "Học lập trình C#", Hinh = "csharp.jpg", NamXb = DateTime.Parse("2023-01-01"), SoTrang = 300, MsTg = "TG001", MsNxb = "NXB001", MsLoai = "LOAI001" },
                new Sach { MsSach = "S002", TenSach = "Java Programming", Dvt = "Cuốn", GiaBan = 300000, MoTa = "Học lập trình Java", Hinh = "java.jpg", NamXb = DateTime.Parse("2022-01-01"), SoTrang = 400, MsTg = "TG002", MsNxb = "NXB002", MsLoai = "LOAI002" },
                new Sach { MsSach = "S003", TenSach = "Python Programming", Dvt = "Cuốn", GiaBan = 280000, MoTa = "Học lập trình Python", Hinh = "python.jpg", NamXb = DateTime.Parse("2021-06-01"), SoTrang = 350, MsTg = "TG001", MsNxb = "NXB003", MsLoai = "LOAI001" },
                new Sach { MsSach = "S004", TenSach = "Data Science with R", Dvt = "Cuốn", GiaBan = 320000, MoTa = "Khoa học dữ liệu với R", Hinh = "r.jpg", NamXb = DateTime.Parse("2020-11-01"), SoTrang = 420, MsTg = "TG003", MsNxb = "NXB001", MsLoai = "LOAI003" },
                new Sach { MsSach = "S005", TenSach = "Machine Learning Basics", Dvt = "Cuốn", GiaBan = 350000, MoTa = "Nhập môn Machine Learning", Hinh = "ml.jpg", NamXb = DateTime.Parse("2023-08-15"), SoTrang = 500, MsTg = "TG004", MsNxb = "NXB002", MsLoai = "LOAI003" },
                new Sach { MsSach = "S006", TenSach = "Deep Learning Essentials", Dvt = "Cuốn", GiaBan = 450000, MoTa = "Những yếu tố cơ bản của Deep Learning", Hinh = "dl.jpg", NamXb = DateTime.Parse("2022-05-21"), SoTrang = 600, MsTg = "TG003", MsNxb = "NXB003", MsLoai = "LOAI003" },
                new Sach { MsSach = "S007", TenSach = "ReactJS Basics", Dvt = "Cuốn", GiaBan = 270000, MoTa = "Học ReactJS từ đầu", Hinh = "react.jpg", NamXb = DateTime.Parse("2023-02-10"), SoTrang = 250, MsTg = "TG005", MsNxb = "NXB001", MsLoai = "LOAI004" },
                new Sach { MsSach = "S008", TenSach = "VueJS Guide", Dvt = "Cuốn", GiaBan = 230000, MoTa = "Hướng dẫn sử dụng VueJS", Hinh = "vue.jpg", NamXb = DateTime.Parse("2022-09-30"), SoTrang = 280, MsTg = "TG005", MsNxb = "NXB002", MsLoai = "LOAI004" },
                new Sach { MsSach = "S009", TenSach = "CSS Flexbox and Grid", Dvt = "Cuốn", GiaBan = 180000, MoTa = "Hướng dẫn CSS Flexbox và Grid", Hinh = "css.jpg", NamXb = DateTime.Parse("2021-04-12"), SoTrang = 150, MsTg = "TG006", MsNxb = "NXB003", MsLoai = "LOAI004" },
                new Sach { MsSach = "S010", TenSach = "JavaScript for Beginners", Dvt = "Cuốn", GiaBan = 210000, MoTa = "Học JavaScript cho người mới bắt đầu", Hinh = "js.jpg", NamXb = DateTime.Parse("2023-03-18"), SoTrang = 200, MsTg = "TG007", MsNxb = "NXB001", MsLoai = "LOAI004" }
            };

            NhaSachs = new List<NhaSach>
            {
                new NhaSach { MsNs = "NS001", TenNs = "Nha Sach ABC", DiaChi = "123 Đường 1, Q.1", KhuVuc = "Khu A", SoDt = "0123456789", SucChua = 100, ConTrong = 50 },
                new NhaSach { MsNs = "NS002", TenNs = "Nha Sach DEF", DiaChi = "456 Đường 2, Q.2", KhuVuc = "Khu B", SoDt = "0987654321", SucChua = 200, ConTrong = 150 },
                new NhaSach { MsNs = "NS003", TenNs = "Nha Sach GHI", DiaChi = "789 Đường 3, Q.3", KhuVuc = "Khu C", SoDt = "0978123456", SucChua = 150, ConTrong = 75 },
                new NhaSach { MsNs = "NS004", TenNs = "Nha Sach JKL", DiaChi = "321 Đường 4, Q.4", KhuVuc = "Khu D", SoDt = "0765432189", SucChua = 300, ConTrong = 200 },
                new NhaSach { MsNs = "NS005", TenNs = "Nha Sach MNO", DiaChi = "159 Đường 5, Q.5", KhuVuc = "Khu E", SoDt = "0909876543", SucChua = 80, ConTrong = 30 },
                new NhaSach { MsNs = "NS006", TenNs = "Nha Sach PQR", DiaChi = "753 Đường 6, Q.6", KhuVuc = "Khu F", SoDt = "0912233445", SucChua = 120, ConTrong = 60 },
                new NhaSach { MsNs = "NS007", TenNs = "Nha Sach STU", DiaChi = "951 Đường 7, Q.7", KhuVuc = "Khu G", SoDt = "0934567890", SucChua = 90, ConTrong = 45 },
                new NhaSach { MsNs = "NS008", TenNs = "Nha Sach VWX", DiaChi = "852 Đường 8, Q.8", KhuVuc = "Khu H", SoDt = "0912345678", SucChua = 110, ConTrong = 80 },
                new NhaSach { MsNs = "NS009", TenNs = "Nha Sach YZ", DiaChi = "753 Đường 9, Q.9", KhuVuc = "Khu I", SoDt = "0965432187", SucChua = 130, ConTrong = 100 },
                new NhaSach { MsNs = "NS010", TenNs = "Nha Sach XYZ", DiaChi = "951 Đường 10, Q.10", KhuVuc = "Khu J", SoDt = "0933456781", SucChua = 140, ConTrong = 60 }
            };

            NhaXuatBans = new List<NhaXuatBan>
            {
                new NhaXuatBan { MsNxb = "NXB001", TenNxb = "NXB Trẻ" },
                new NhaXuatBan { MsNxb = "NXB002", TenNxb = "NXB Kim Đồng" },
                new NhaXuatBan { MsNxb = "NXB003", TenNxb = "NXB Giáo Dục" },
                new NhaXuatBan { MsNxb = "NXB004", TenNxb = "NXB Văn Học" },
                new NhaXuatBan { MsNxb = "NXB005", TenNxb = "NXB Hội Nhà Văn" },
                new NhaXuatBan { MsNxb = "NXB006", TenNxb = "NXB Lao Động" },
                new NhaXuatBan { MsNxb = "NXB007", TenNxb = "NXB Công An" },
                new NhaXuatBan { MsNxb = "NXB008", TenNxb = "NXB Sự Thật" },
                new NhaXuatBan { MsNxb = "NXB009", TenNxb = "NXB Phụ Nữ" },
                new NhaXuatBan { MsNxb = "NXB010", TenNxb = "NXB Thanh Niên" }
            };

            TacGias = new List<TacGia>
            {
                new TacGia { MsTg = "TG001", TenTg = "Nguyen Van X", DiaChi = "789 Đường Z", SoDt = "1122334455" },
                new TacGia { MsTg = "TG002", TenTg = "Tran Van Y", DiaChi = "321 Đường W", SoDt = "5566778899" },
                new TacGia { MsTg = "TG003", TenTg = "Le Thi A", DiaChi = "567 Đường C", SoDt = "6677889900" },
                new TacGia { MsTg = "TG004", TenTg = "Nguyen Thi B", DiaChi = "890 Đường B", SoDt = "7788990011" },
                new TacGia { MsTg = "TG005", TenTg = "Pham Van C", DiaChi = "123 Đường F", SoDt = "8899001122" },
                new TacGia { MsTg = "TG006", TenTg = "Tran Thi D", DiaChi = "456 Đường A", SoDt = "9900112233" },
                new TacGia { MsTg = "TG007", TenTg = "Nguyen Van E", DiaChi = "789 Đường G", SoDt = "1011121314" },
                new TacGia { MsTg = "TG008", TenTg = "Do Thi H", DiaChi = "321 Đường H", SoDt = "1213141516" },
                new TacGia { MsTg = "TG009", TenTg = "Pham Van K", DiaChi = "654 Đường L", SoDt = "1314151617" },
                new TacGia { MsTg = "TG010", TenTg = "Hoang Thi M", DiaChi = "987 Đường P", SoDt = "1415161718" }
            };

            LoaiSachs = new List<LoaiSach>
            {
                new LoaiSach { MsLoai = "LOAI001", TenLoai = "Sách lập trình" },
                new LoaiSach { MsLoai = "LOAI002", TenLoai = "Sách văn học" },
                new LoaiSach { MsLoai = "LOAI003", TenLoai = "Sách thiếu nhi" },
                new LoaiSach { MsLoai = "LOAI004", TenLoai = "Sách khoa học" },
                new LoaiSach { MsLoai = "LOAI005", TenLoai = "Sách giáo dục" },
                new LoaiSach { MsLoai = "LOAI006", TenLoai = "Sách lịch sử" },
                new LoaiSach { MsLoai = "LOAI007", TenLoai = "Sách kinh tế" },
                new LoaiSach { MsLoai = "LOAI008", TenLoai = "Sách văn hóa" },
                new LoaiSach { MsLoai = "LOAI009", TenLoai = "Sách du lịch" },
                new LoaiSach { MsLoai = "LOAI010", TenLoai = "Sách ngoại ngữ" }
            };

            HoaDons = new List<HoaDon>
            {
                new HoaDon { MsHd = "HD001", NgayLap = DateTime.Now, MsKh = "KH001", MsNv = "NV001", TongTien = 500000, DienGiai = "Mua sách", Loai = 1 },
                new HoaDon { MsHd = "HD002", NgayLap = DateTime.Now, MsKh = "KH002", MsNv = "NV002", TongTien = 300000, DienGiai = "Mua sách", Loai = 2 },
                new HoaDon { MsHd = "HD003", NgayLap = DateTime.Now, MsKh = "KH003", MsNv = "NV003", TongTien = 200000, DienGiai = "Mua sách", Loai = 1 },
                new HoaDon { MsHd = "HD004", NgayLap = DateTime.Now, MsKh = "KH004", MsNv = "NV004", TongTien = 450000, DienGiai = "Mua sách", Loai = 1 },
                new HoaDon { MsHd = "HD005", NgayLap = DateTime.Now, MsKh = "KH005", MsNv = "NV005", TongTien = 550000, DienGiai = "Mua sách", Loai = 2 },
                new HoaDon { MsHd = "HD006", NgayLap = DateTime.Now, MsKh = "KH006", MsNv = "NV006", TongTien = 300000, DienGiai = "Mua sách", Loai = 1 },
                new HoaDon { MsHd = "HD007", NgayLap = DateTime.Now, MsKh = "KH007", MsNv = "NV007", TongTien = 600000, DienGiai = "Mua sách", Loai = 2 },
                new HoaDon { MsHd = "HD008", NgayLap = DateTime.Now, MsKh = "KH008", MsNv = "NV008", TongTien = 700000, DienGiai = "Mua sách", Loai = 1 },
                new HoaDon { MsHd = "HD009", NgayLap = DateTime.Now, MsKh = "KH009", MsNv = "NV009", TongTien = 800000, DienGiai = "Mua sách", Loai = 2 },
                new HoaDon { MsHd = "HD010", NgayLap = DateTime.Now, MsKh = "KH010", MsNv = "NV010", TongTien = 650000, DienGiai = "Mua sách", Loai = 1 }
            };

            ChiTietHoaDons = new List<ChiTietHoaDon>
            {
                new ChiTietHoaDon { MsHd = "HD001", MsSach = "S001", SoLuong = 2 },
                new ChiTietHoaDon { MsHd = "HD002", MsSach = "S002", SoLuong = 1 },
                new ChiTietHoaDon { MsHd = "HD003", MsSach = "S003", SoLuong = 4 },
                new ChiTietHoaDon { MsHd = "HD004", MsSach = "S004", SoLuong = 3 },
                new ChiTietHoaDon { MsHd = "HD005", MsSach = "S005", SoLuong = 5 },
                new ChiTietHoaDon { MsHd = "HD006", MsSach = "S006", SoLuong = 1 },
                new ChiTietHoaDon { MsHd = "HD007", MsSach = "S007", SoLuong = 2 },
                new ChiTietHoaDon { MsHd = "HD008", MsSach = "S008", SoLuong = 4 },
                new ChiTietHoaDon { MsHd = "HD009", MsSach = "S009", SoLuong = 1 },
                new ChiTietHoaDon { MsHd = "HD010", MsSach = "S010", SoLuong = 3 }
            };

            Bills = new List<Bill>
            {
                new Bill { MsBill = "BILL001", NgayLap = DateTime.Now, MsKh = "KH001", MsNv = "NV001", MsHd = "HD001", Loai = 1 },
                new Bill { MsBill = "BILL002", NgayLap = DateTime.Now, MsKh = "KH002", MsNv = "NV002", MsHd = "HD002", Loai = 2 },
                new Bill { MsBill = "BILL003", NgayLap = DateTime.Now, MsKh = "KH003", MsNv = "NV003", MsHd = "HD003", Loai = 1 },
                new Bill { MsBill = "BILL004", NgayLap = DateTime.Now, MsKh = "KH004", MsNv = "NV004", MsHd = "HD004", Loai = 2 },
                new Bill { MsBill = "BILL005", NgayLap = DateTime.Now, MsKh = "KH005", MsNv = "NV005", MsHd = "HD005", Loai = 1 },
                new Bill { MsBill = "BILL006", NgayLap = DateTime.Now, MsKh = "KH006", MsNv = "NV006", MsHd = "HD006", Loai = 2 },
                new Bill { MsBill = "BILL007", NgayLap = DateTime.Now, MsKh = "KH007", MsNv = "NV007", MsHd = "HD007", Loai = 1 },
                new Bill { MsBill = "BILL008", NgayLap = DateTime.Now, MsKh = "KH008", MsNv = "NV008", MsHd = "HD008", Loai = 2 },
                new Bill { MsBill = "BILL009", NgayLap = DateTime.Now, MsKh = "KH009", MsNv = "NV009", MsHd = "HD009", Loai = 1 },
                new Bill { MsBill = "BILL010", NgayLap = DateTime.Now, MsKh = "KH010", MsNv = "NV010", MsHd = "HD010", Loai = 2 }
            };

            ChiTietBills = new List<ChiTietBill>
            {
                new ChiTietBill { MsBill = "BILL001", MsSach = "S001", SoLuong = 2 },
                new ChiTietBill { MsBill = "BILL002", MsSach = "S002", SoLuong = 1 },
                new ChiTietBill { MsBill = "BILL003", MsSach = "S003", SoLuong = 4 },
                new ChiTietBill { MsBill = "BILL004", MsSach = "S004", SoLuong = 3 },
                new ChiTietBill { MsBill = "BILL005", MsSach = "S005", SoLuong = 5 },
                new ChiTietBill { MsBill = "BILL006", MsSach = "S006", SoLuong = 1 },
                new ChiTietBill { MsBill = "BILL007", MsSach = "S007", SoLuong = 2 },
                new ChiTietBill { MsBill = "BILL008", MsSach = "S008", SoLuong = 4 },
                new ChiTietBill { MsBill = "BILL009", MsSach = "S009", SoLuong = 1 },
                new ChiTietBill { MsBill = "BILL010", MsSach = "S010", SoLuong = 3 }
            };
        }
    }
}
