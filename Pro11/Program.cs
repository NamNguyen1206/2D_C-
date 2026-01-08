using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo đối tượng quản lý gói dịch vụ
            QuanLy QuanLyGoiDichVu = new QuanLy();

            // Hiển thị tất cả các gói dịch vụ
            Console.WriteLine("Danh sách các gói dịch vụ hiện có:");
            QuanLyGoiDichVu.HienThiTatCaGoiDich();

            while (true)
            {
                // Người dùng chọn gói dịch vụ
                GoiDichVu goiChon = QuanLyGoiDichVu.ChonGoiDichVu();

                // Kiểm tra người dùng chọn gói hợp lệ
                if (goiChon != null)
                {
                    Console.WriteLine("\nThông tin gói dịch vụ bạn chọn:");
                    goiChon.HienThiThongTin();
                }
                else
                {
                    Console.WriteLine("\nGói dịch vụ không hợp lệ. Vui lòng thử lại.");
                }

                // Hỏi người dùng có muốn chọn lại không
                Console.WriteLine("\nBạn có muốn chọn gói dịch vụ khác không? (y/n): ");
                string userChoice = Console.ReadLine()?.Trim().ToLower();

                if (userChoice != "y")
                {
                    Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ!");
                    break;  // Thoát khỏi vòng lặp nếu người dùng không muốn chọn gói khác
                }
            }
            Console.ReadKey();
        }
    }
}
