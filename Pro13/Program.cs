using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pro13.NhomMau;
using static Pro13.XuLyNhomMau;

namespace Pro13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
                // Bước 1: Nhập danh sách người và nhóm máu của họ
                List<Nguoi> danhSach = new List<Nguoi>();

                // Nhập số người
                Console.Write("Nhập số lượng người: ");
                int soLuong = int.Parse(Console.ReadLine());

                for (int i = 0; i < soLuong; i++)
                {
                    // Nhập thông tin mỗi người
                    Console.WriteLine($"\nNhập thông tin người thứ {i + 1}:");

                    // Nhập tên người
                    Console.Write("Nhập tên người: ");
                    string hoTen = Console.ReadLine();

                    // Nhập nhóm máu
                    Console.Write("Nhập nhóm máu (O, A, B, AB): ");
                    string loaiNhomMauStr = Console.ReadLine();
                    LoaiNhomMau loaiNhomMau = (LoaiNhomMau)Enum.Parse(typeof(LoaiNhomMau), loaiNhomMauStr);

                    // Nhập Rh
                    Console.Write("Nhập Rh (Duong, Am): ");
                    string rhStr = Console.ReadLine();
                    Rh rh = (Rh)Enum.Parse(typeof(Rh), rhStr);

                    // Thêm người vào danh sách
                    danhSach.Add(new Nguoi(hoTen, new NhomMau(loaiNhomMau, rh)));
                }

                // In danh sách người và nhóm máu
                Console.WriteLine("\n=== DANH SÁCH NGƯỜI ===");
                foreach (var n in danhSach)
                Console.WriteLine(n);

                Console.WriteLine("\n=== KIỂM TRA ===");

                // Bước 2: Kiểm tra tính hợp lệ của nhóm máu cha, mẹ và con
                var cha = new NhomMauInfo(LoaiNhomMau.A, Rh.Duong);
                var me = new NhomMauInfo(LoaiNhomMau.B, Rh.Am);
                var con = new NhomMauInfo(LoaiNhomMau.O, Rh.Am);

                bool hopLe = XuLyNhomMau.KiemTraDiTruyen(cha, me, con);
                Console.WriteLine(hopLe ? "Phu hop" : "Không phu hop");

                // Bước 3: Kiểm tra ai có thể cho máu 
                Console.WriteLine("\n=== NGƯỜI CÓ THỂ CHO MÁU ===");
                if (danhSach.Count > 3)
                {
                    Nguoi nguoiNhan = danhSach[3]; 

                    foreach (var nguoi in danhSach)
                    {
                        if (nguoi != nguoiNhan)
                        {
                            // Chuyển đổi NhomMau sang NhomMauInfo trước khi gọi phương thức CoTheChoMau
                            NhomMauInfo nguoiChoInfo = new NhomMauInfo(nguoi.NhomMau.LoaiNhomMau, nguoi.NhomMau.Rh);
                            NhomMauInfo nguoiNhanInfo = new NhomMauInfo(nguoiNhan.NhomMau.LoaiNhomMau, nguoiNhan.NhomMau.Rh);

                            if (XuLyNhomMau.CoTheChoMau(nguoiChoInfo, nguoiNhanInfo))
                            {
                                Console.WriteLine(nguoi);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Không co ai trong danh sach phu hop.");
                }
                Console.ReadLine();
            }
        }   
    }
}


