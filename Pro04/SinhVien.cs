using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pro04
{
    internal class SinhVien
    {
        public string ten;
        public int tuoi;
        public double diemLT;
        public double diemTH;
        public SinhVien() 
        {

        }
        public SinhVien(string ht, int t, double diemLT, double diemTH)
        {
            this.ten = ht;
            this.tuoi = t;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        } 
        public void Nhap()
        {
            Console.WriteLine("Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            this.tuoi= int.Parse(Console.ReadLine());
            Console.WriteLine("Diem TL");
            this.diemLT = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem TH");
            this.diemTH = double.Parse(Console.ReadLine());


        }
        public void Xuat()
        {
            Console.WriteLine($"Thông tin SV: {this.ten} - tuoi {this.tuoi} - LT:{this.diemLT} - TH: {this.diemTH}");
        }
        public double DTB()
        {
            return (this.diemTH+this.diemTH)/2; 
        }

    }
}
