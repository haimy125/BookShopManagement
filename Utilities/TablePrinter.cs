using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookShopManagement.Utilities
{
    internal class TablePrinter
    {
        public static void PrintTable<T>(string title, string[] columnNames, List<T> items, params Expression<Func<T, object>>[] propertySelectors)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Kiểm tra xem số lượng cột có khớp với số lượng propertySelectors không
            if (columnNames.Length != propertySelectors.Length)
            {
                throw new ArgumentException("Số lượng tên cột phải bằng số lượng thuộc tính được chỉ định.");
            }

            // Tính toán độ rộng tối đa cho mỗi cột
            int[] columnWidths = new int[columnNames.Length];

            // Thiết lập độ rộng cho các tiêu đề cột
            for (int i = 0; i < columnNames.Length; i++)
            {
                columnWidths[i] = columnNames[i].Length; // Độ rộng tiêu đề
            }

            // Tính toán độ rộng cho từng giá trị trong danh sách
            foreach (var item in items)
            {
                for (int i = 0; i < columnNames.Length; i++)
                {
                    // Lấy giá trị từ propertySelector
                    var value = propertySelectors[i].Compile()(item)?.ToString() ?? ""; // Giá trị mặc định là chuỗi rỗng
                    columnWidths[i] = Math.Max(columnWidths[i], value.Length); // Độ rộng giá trị
                }
            }

            // In tiêu đề
            Console.WriteLine(title);
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");

            // In dòng tiêu đề
            for (int i = 0; i < columnNames.Length; i++)
            {
                Console.Write($"| {columnNames[i].PadRight(columnWidths[i])} ");
            }
            Console.WriteLine("|");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");

            // In từng mục
            foreach (var item in items)
            {
                for (int i = 0; i < columnNames.Length; i++)
                {
                    var value = propertySelectors[i].Compile()(item)?.ToString() ?? ""; // Giá trị mặc định là chuỗi rỗng
                    Console.Write($"| {value.PadRight(columnWidths[i])} "); // Căn lề trái cho các giá trị
                }
                Console.WriteLine("|");
            }

            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
        }
    }
}
