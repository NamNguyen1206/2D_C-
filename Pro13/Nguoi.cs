using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro13
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public NhomMau NhomMau { get; set; }

        public Nguoi(string hoTen, NhomMau nhomMau)
        {
            HoTen = hoTen;
            NhomMau = nhomMau;
        }

        public override string ToString()
        {
            return $"{HoTen} - Nhóm máu: {NhomMau}";
        }
    }
}
