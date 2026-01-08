using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10
{
    internal class De : GiaSuc
    {
        public override string Keu()
        {
            return "Dê: Be Be";
        }
        public override int ChoSua ()
        {
            int tongSua = 0;
            for (int i = 0; i < 10; i++)
            {
                tongSua += rnd.Next(0, 11);
            }
            return tongSua;
        }
        public override void Nhap()
        {
            Console.Write("Nhập số de: ");
            SoLuong = int.Parse(Console.ReadLine());
        }
    }
}
