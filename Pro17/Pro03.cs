using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pro17
{
    class DsSanPham
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
    internal class Pro03
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<DsSanPham> dsSanPhams = new List<DsSanPham>()
            {
            new DsSanPham{ID = 1,SKU = "WT3WPG",Name = "Tuoi tre dang gia bao nhieu" , Author = "Rosie Nguyen", Price = 45000, Stock = 40},
            new DsSanPham{ID = 2,SKU = "98IOWW",Name = "Luyen thi THPT Quoc Gia - Hoa Hoc" , Author = "Nguyen Duc Dung", Price = 51000, Stock = 15},
            new DsSanPham{ID = 3,SKU = "21RH48",Name = "Kheo an kheo noi se co duoc thien ha" , Author = "Trac Nha", Price = 59000, Stock = 29},
            new DsSanPham{ID = 4,SKU = "QOXYSD",Name = "Nha gia kim" , Author = "Paulo Coelho", Price = 53000, Stock = 3},
            new DsSanPham{ID = 5,SKU = "6IY6TZ",Name = "De yen cho bac si 'Hien'" , Author = "BS.Ngo Duc Hung", Price = 45000, Stock = 36},
            new DsSanPham{ID = 6,SKU = "YHB5JT", Name = "Mình là cá, việc của mình là bơi", Author = "Takeshi Furukawa", Price = 51000, Stock = 9 },
            new DsSanPham{ID = 7, SKU = "LXL64L", Name = "Đời ngắn đừng ngủ dài", Author = "Robin Sharma", Price = 42000, Stock = 7 },
            new DsSanPham{ID = 8, SKU = "C5V645", Name = "Luyện thi THPT Quốc gia − Toán", Author = "ThS. Đỗ Đường Hiếu", Price = 51000, Stock = 0 },
            new DsSanPham{ID = 9, SKU = "4KLYT2", Name = "Cà phê cùng Tony", Author = "Tony Buổi Sáng", Price = 62000, Stock = 18 },
            new DsSanPham{ID = 10, SKU = "KBD67V", Name = "Em sẽ đến cùng cơn mưa", Author = "Ichikawa Takuji", Price = 56000, Stock = 64 },
            new DsSanPham{ID = 11, SKU = "3RISEF", Name = "Quẳng gánh lo đi mà vui sống", Author = "Dale Carnegie", Price = 45000, Stock = 120 },
            new DsSanPham{ID = 12, SKU = "VIAZXR", Name = "Mình nói gì khi nói về hạnh phúc?", Author = "Rosie Nguyễn", Price = 36000, Stock = 0 }
            };
            var DsSanPham = dsSanPhams.OrderBy(s => s.Price).OrderByDescending(s => s.Stock); ;
            //DsSanPham = dsSanPhams.OrderBy(s => s.Price).OrderByDescending(s =>s.Stock);
            foreach (var sp in DsSanPham)
            {
                Console.WriteLine($"ID: {sp.ID}, SKU: {sp.SKU}, Name: {sp.Name}, Author: {sp.Author}, Price: {sp.Price}, Stock: {sp.Stock}");
            }
            var DsSanPham2 = dsSanPhams.Where(s => s.Stock <10);
            Console.WriteLine("########Sản phẩm có số lượng dưới 10########");
            foreach (var sp in DsSanPham2)
            {
                Console.WriteLine($"ID: {sp.ID}, SKU: {sp.SKU}, Name: {sp.Name}, Author: {sp.Author}, Price: {sp.Price}, Stock: {sp.Stock}");
            }
            var DsSanPham3 = dsSanPhams.Where(s => s.Stock == 0);
            Console.WriteLine("########Sản phẩm hết hàng########");
            foreach (var sp in DsSanPham3)
            {
                Console.WriteLine($"ID: {sp.ID}, SKU: {sp.SKU}, Name: {sp.Name}, Author: {sp.Author}, Price: {sp.Price}, Stock: {sp.Stock}");
            }
            var DsSanPham7 = dsSanPhams.Where(s => s.Author == "Rosie Nguyễn").Where(s => s.Stock > 0);
            Console.WriteLine("########Sản phẩm của tác giả Rosie Nguyễn còn hàng########");
            foreach (var sp in DsSanPham7)
            {
                Console.WriteLine($"ID: {sp.ID}, SKU: {sp.SKU}, Name: {sp.Name}, Author: {sp.Author}, Price: {sp.Price}, Stock: {sp.Stock}");
            }
            var Top5SanPham = dsSanPhams.OrderByDescending(s => s.Price).Take(5);
            foreach (var sp in Top5SanPham)
            {
                Console.WriteLine($"ID: {sp.ID}, SKU: {sp.SKU}, Name: {sp.Name}, Author: {sp.Author}, Price: {sp.Price}, Stock: {sp.Stock}");
            }
            Console.WriteLine("########Top 5 sản phẩm có giá cao nhất########");
            
            var DsSanPham4 = dsSanPhams.Where(s => s.Price >= 50000);
            Console.WriteLine("########Sản phẩm có giá từ 50000 trở lên########");
            foreach (var sp in DsSanPham4)
            {
                Console.WriteLine($"ID: {sp.ID}, SKU: {sp.SKU}, Name: {sp.Name}, Author: {sp.Author}, Price: {sp.Price}, Stock: {sp.Stock}");
            }
            var DsSanPham5 = dsSanPhams.Average(s => s.Price);
            Console.WriteLine($"########Giá trung bình của tất cả sản phẩm: {DsSanPham5}########");
            var DsSanPham6 = dsSanPhams.Where(s => s.Stock>0).Sum(s => s.Price);
            Console.WriteLine($"########Tổng giá của tất cả sản phẩm còn hàng: {DsSanPham6}########");
            Console.ReadKey();
        }
    }
}
