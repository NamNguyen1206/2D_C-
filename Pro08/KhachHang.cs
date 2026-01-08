using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro08
{
    internal abstract class KhachHang
    {
        protected string MaKH;
        protected string HoTen;
        protected DateTime NgayLapHD;
        protected double SoDien;
        protected double DonGia;
        //public KhachHang(string maKH, string hoTen, DateTime ngayLapHD, double soDien, double donGia)
        //{
        //    MaKH = maKH;
        //    HoTen = hoTen;
        //    NgayLapHD = ngayLapHD;
        //    SoDien = SoDien;
        //    DonGia = DonGia;
        //}
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ma khach hang");
            this.MaKH = Console.ReadLine();
            Console.WriteLine("Nhap ngay xuat hoa don dd / MM / yyyy");
            string temp = Console.ReadLine();
            DateTime.TryParseExact(temp, " dd / MM / yyyy", null, System.Globalization.DateTimeStyles.None, out this.NgayLapHD);
            Console.WriteLine("Nhap dien tieu thu");
            this.SoDien = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap don gia ");
            this.DonGia = double.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine($"Ma KH: {MaKH}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Ngay lap HĐ: {NgayLapHD:dd/MM/yyyy}");
            Console.WriteLine($"So đien tieu thu: {SoDien}");
            Console.WriteLine($"Don giá: {DonGia}");
        }
        public abstract double TinhTien();
    }
}
