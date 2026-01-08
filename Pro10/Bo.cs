using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10
{
    internal class Bo : GiaSuc
    {
        public override string Keu()
        {
            return "Bo: Um Bo";
        }
        public override int ChoSua()
        {
            int tongSua = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                tongSua += rnd.Next(0, 21); // 0 – 20 lít
            }
            return tongSua;
        }
        public override void Nhap()
        {
            Console.Write("Nhập số Bo: ");
            SoLuong = int.Parse(Console.ReadLine());
        }
    }
}
