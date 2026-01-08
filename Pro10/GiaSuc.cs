using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10
{
    internal abstract class GiaSuc
    {
        protected static Random rnd = new Random();
        public int SoLuong { get; protected set; }

        public abstract void Nhap();
        public abstract string Keu();
        public abstract int ChoSua();
        public GiaSuc() { }
        public int SinhCon()
        {
            int tongCon = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                tongCon += rnd.Next(1, 5); // 1 → 4
            }
            return tongCon;
        }
    }
}
