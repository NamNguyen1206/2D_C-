using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro08
{
    internal abstract class DongVat
    {
        protected string ten;
        protected int tuoi;
        public void Nhap()
        {
            Console.WriteLine("Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            this.tuoi=int .Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Ten: {this.ten} , Tuoi: {this.tuoi}");
        }
        public abstract void TiengMeo();
    }
}
