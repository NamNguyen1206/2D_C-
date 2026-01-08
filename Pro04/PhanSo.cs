using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro04
{
    internal class PhanSo
    {
        public int tuSo;
        public int mauSo;

        public PhanSo()
        {

        }
        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0) mauSo = 1;
            this.tuSo = tuSo;
            this.mauSo = mauSo;
            RutGon();
        }

        public void RutGon()
        {
            int u = UCLN(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo /= u;
            mauSo /= u;
            if (mauSo < 0) { tuSo = -tuSo; mauSo = -mauSo; }
        }
        public int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        //Sai
        //public void Nhap(int a ,int b,int c, int d )
        //{
        //    Console.WriteLine("Nhập phân số thứ nhất:");
        //    this.tuSo = int.Parse(Console.ReadLine()); 
        //    this.mauSo = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Nhập phân số thứ hai:");
        //    this.tuSo = int.Parse(Console.ReadLine());
        //    this.mauSo = int.Parse(Console.ReadLine());
        //}

        //Dung
        public void Nhap()
        {
            Console.Write("Tu so: ");
            this.tuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so: ");
            this.mauSo = int.Parse(Console.ReadLine());
            if (this.mauSo == 0) this.mauSo = 1;
            RutGon();
        }

        public void Xuat()
        {
            Console.WriteLine($"Tu so : {this.tuSo} -- Mau so : {this.mauSo}");
        }
        public PhanSo Cong(PhanSo f)
        {
            return new PhanSo(tuSo * f.mauSo + f.tuSo * mauSo, mauSo * f.mauSo);
        }
        public PhanSo Tru(PhanSo f)
        {
            return new PhanSo(tuSo * f.mauSo - f.tuSo * mauSo, mauSo * f.mauSo);
        }

        public PhanSo Nhan(PhanSo f)
        {
            return new PhanSo(tuSo * f.tuSo, mauSo * f.mauSo);
        }

        public PhanSo Chia(PhanSo f)
        {
            return new PhanSo(tuSo * f.mauSo, mauSo * f.tuSo);
        }
        public override string ToString()
        {
            return $"{tuSo}/{mauSo}";
        }

    }
}
