using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro09
{
    internal class DocGiaTreEm:DocGia
    {
        public string NguoiBaoHo { get; set; }
        private const int GiaVe = 30000;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập tên người bảo hộ: ");
            this.NguoiBaoHo = Console.ReadLine();   
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Người bảo hộ: {NguoiBaoHo}");
            Console.WriteLine("Loại độc giả: Trẻ em");
        }
        public override double TinhTien()
        {
            return SoThang * GiaVe;
        }
    }
}
