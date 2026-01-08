using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Khởi tạo đối tượng 
            QuanLy game = new QuanLy();
            // Gọi phương thức nhập danh sách nhân vật
            game.InputNhanVat();
            // Kiểm tra va chạm giữa các nhân vật
            game.KiemTraVaCham();
            Console.ReadKey();
        }
    }
}
