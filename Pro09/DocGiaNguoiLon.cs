using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro09
{
    internal class DocGiaNguoiLon:DocGia
    {
        public string CCCD { get; set; }
        private const int GiaVe = 50000;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số CCCD: ");
            this.CCCD = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"CCCD: {CCCD}");
            Console.WriteLine("Loại độc giả: Người lớn");
        }
        public override double TinhTien()
        {
            return SoThang * GiaVe;
        }
    }
}
