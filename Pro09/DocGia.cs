using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro09
{
    internal abstract class DocGia
    {
        protected string HoTen { get; set; }
        protected int SoThang { get; set; }

        public abstract double TinhTien();

        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập số tháng: ");
            SoThang = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Số tháng: {SoThang}");
        }
    }
}
