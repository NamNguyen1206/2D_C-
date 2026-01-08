using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Pro08
{
    internal class KhachHangVietNam : KhachHang
    {
        public const string SANXUAT = "San xuat";
        public const string SINHHOAT = "Sinh hoat";
        public const string KINHDOANH = "Kinh doanh";

        private string DoiTuong;
        public double DinhMuc;
        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine($"Nhap doi tuong KH: ");
            Console.WriteLine($"1.Sinh Hoat ");
            Console.WriteLine($"2.San Xuat ");
            Console.WriteLine($"2.Kinh Doanh ");
            int LuaChon = int .Parse( Console.ReadLine() );
            if (LuaChon == 1)
            {
                this.DoiTuong = SINHHOAT;
            }
            else if (LuaChon == 2)
            {
                this.DoiTuong = SANXUAT;
            }
            else
            {
                this.DoiTuong = KINHDOANH;
            }
            Console.WriteLine("Nhap dinh muc: ");
            this.DinhMuc = double.Parse( Console.ReadLine() );
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Doi tuong KH: {DoiTuong}");
            Console.WriteLine($"Dinh muc: {DinhMuc}");
            Console.WriteLine($"Thanh tien: {TinhTien()} đ");
        }
        public override double TinhTien()
        {
            if (SoDien <= DinhMuc)
                return SoDien * DonGia;
            else
            {
                double phanVuot = SoDien - DinhMuc;
                return DinhMuc * DonGia + phanVuot * DonGia * 2.5;
            }
        }
    }
}
