using System;

namespace Pro04
{
    internal class Pro03
    {
        static void Main(string[] args)
        {

            PhanSo f1 = new PhanSo();
            PhanSo f2 = new PhanSo();

            Console.WriteLine("Nhap phan so thu nhat:");
            f1.Nhap();

            Console.WriteLine("Nhap phan so thu hai:");
            f2.Nhap();

            Console.WriteLine("Phan so thu nhat: " + f1);
            Console.WriteLine("Phan so thu hai: " + f2);

            Console.WriteLine("Tong la : " + f1.Cong(f2));
            Console.WriteLine("Hieu la : " + f1.Tru(f2));
            Console.WriteLine("Nhan la : " + f1.Nhan(f2));
            Console.WriteLine("Chia la : " + f1.Chia(f2));

            Console.ReadKey();
        }
    }
}
