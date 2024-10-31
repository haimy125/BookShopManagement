using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagement.Data;
using BookShopManagement.Models;
using BookShopManagement.Services;

namespace BookShopManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("═══════════════════════ Menu ════════════════════════");
                Console.WriteLine("1. Lấy danh sách khách hàng");
                Console.WriteLine("2. Lấy danh sách sách có giá bán lớn hơn 250.000");
                Console.WriteLine("3. Lấy tên nhân viên theo mã nhân viên");
                Console.WriteLine("4. Lấy danh sách hóa đơn theo tổng tiền lớn hơn một giá trị cụ thể");
                Console.WriteLine("5. Lấy danh sách sách theo loại");
                Console.WriteLine("6. Lấy danh sách hóa đơn theo khách hàng");
                Console.WriteLine("7. Lấy danh sách chi tiết hóa đơn của một hóa đơn cụ thể");
                Console.WriteLine("8. Lấy thông tin sách theo tên");
                Console.WriteLine("9. Lấy danh sách hóa đơn theo ngày lập");
                Console.WriteLine("10. Lấy danh sách sách có mô tả chứa từ khóa");
                Console.WriteLine("11. Thoát");
                Console.Write("Chọn một tùy chọn (1-11): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            QueryService.getDachSachKhachHang();
                            break;
                        case 2:
                            QueryService.getSachCoGiaCao();
                            break;
                        case 3:
                            QueryService.getNhanVienTheoMa();
                            break;
                        case 4:
                            QueryService.getHoaDonTheoTongTien();
                            break;
                        case 5:
                            QueryService.getSachTheoLoai();
                            break;
                        case 6:
                            QueryService.getDsHdTheoKh();
                            break;
                        case 7:
                            QueryService.getChiTietHoaDon();
                            break;
                        case 8:
                            QueryService.getSachTheoTen();
                            break;
                        case 9:
                            QueryService.getHoaDonTheoNgay();
                            break;
                        case 10:
                            QueryService.getSachTheoMoTa();
                            break;
                        case 11:
                            Console.WriteLine("Thoát chương trình.");
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 1 đến 11.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số từ 1 đến 11.");
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
