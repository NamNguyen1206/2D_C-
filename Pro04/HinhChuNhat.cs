using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro04
{
    internal class HinhChuNhat
    {
        public int chieuDai;
        public int chieuRong;

        public HinhChuNhat()
        {

        }
        public void Nhap()
        {
            Console.WriteLine("Nhap dieu dai: ");
            this.chieuDai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dieu rong: ");
            this.chieuRong = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Chieu dai : {this.chieuDai} -- Chieu rong : {this.chieuRong}");
        }
        public double ChuVi()
        {
            return (this.chieuDai + this.chieuRong)*2;
        }
        public double DienTich()
        {
            return (this.chieuDai * this.chieuRong);
        }
    }

}
