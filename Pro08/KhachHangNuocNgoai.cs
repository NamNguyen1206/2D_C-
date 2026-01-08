using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro08
{
    internal class KhachHangNuocNgoai:KhachHang
    {
        private string quocTich;
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap quoc tich: ");
            this.quocTich = Console.ReadLine();
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Quoc tich: {this.quocTich}");
        }
        public override double TinhTien()
        {
            return SoDien * DonGia * 2.5;
        }
    }
}
