using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    internal class GioXuyenTam: KiNang
    {
        public GioXuyenTam()
        {
            TenKN = "Gió Xuyên Tâm";
            SatThuong = 25;
            HeSoSucManh = 2.0;
            ManaTieuThu = 6;
        }

        public override double TinhHieuSuat() => TinhSatThuongThucTe() / TinhManaCanThiet();
    }
}
