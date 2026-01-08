using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo danh sách các kỹ năng
            List<KiNang> kiNangs = new List<KiNang>
        {
            new LuaHuyDiet(),
            new GioXuyenTam(),
            new SongSetThan(),
            new KiemAoAnh(),
            new LuoiHaiBongToi()
        };

            // Hiển thị thông tin kỹ năng
            foreach (var kn in kiNangs)
            {
                Console.WriteLine($"Kỹ năng: {kn.TenKN}, Sát thương thực tế: {kn.TinhSatThuongThucTe()}, Mana cần thiết: {kn.TinhManaCanThiet()}");
            }

            // Tính tổng mana cần thiết
            double TongMana = kiNangs.Sum(kn => kn.TinhManaCanThiet());
            Console.WriteLine($"\nTổng mana cần thiết để sử dụng tất cả kỹ năng: {TongMana} Mana");
            // Top 5 ki nang theo hieu xuat sat thuong
            var top5KiNang = kiNangs.OrderByDescending(kn => kn.TinhHieuSuat()).Take(5);
            Console.WriteLine("\nTop 5 kỹ năng theo hiệu suất sát thương:");
            foreach (var kn in top5KiNang)
            {
                Console.WriteLine($"Kỹ năng: {kn.TenKN}, Hiệu suất sát thương: {kn.TinhHieuSuat()}");
            }
            Console.ReadKey();
        }
    }
}
