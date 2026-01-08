using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro08
{
    internal class Meo:DongVat
    {
        private string loaiMeo;
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap loai meo: ");
            this.loaiMeo = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loai meo: {this.loaiMeo}");
        }
        public override void TiengMeo()
        {   
            Console.WriteLine("neo");
        }
    }
}
