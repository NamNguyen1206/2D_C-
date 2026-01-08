using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro08
{
    internal class Pro02
    {
        static void Main(string[] args)
        {
            int LuaChon;

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Moi ban nhap lua chon ");
                Console.WriteLine("1. KH Viet Nam ");
                Console.WriteLine("2. KH Nuoc Ngoai ");
                Console.WriteLine("3. Exit ");
                Console.WriteLine("----------------------");
                LuaChon = int.Parse(Console.ReadLine());
                if (LuaChon == 1)
                {
                    KhachHangVietNam a = new KhachHangVietNam();
                    a.Nhap();
                    a.Xuat();
                }
                else if (LuaChon == 2)
                {
                    KhachHangVietNam a = new KhachHangVietNam();
                    a.Nhap();
                    a.Xuat();
                }
                else
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
