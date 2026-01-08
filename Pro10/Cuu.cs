using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10
{
    internal class Cuu:GiaSuc
    {
        public override string Keu()
        {
            return "Cuu: Be Be";
        }
        public override int ChoSua()
        {
            int tongSua = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                tongSua += rnd.Next(0, 6); // 0 – 5 lít
            }
            return tongSua;
        }
        public override void Nhap()
        {
            Console.Write("Nhập số cuu: ");
            SoLuong = int.Parse(Console.ReadLine());
        }
    }
}
