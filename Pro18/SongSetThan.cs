using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    internal class SongSetThan: KiNang
    {
        public SongSetThan()
        {
            TenKN = "Sóng Sét Thần";
            SatThuong = 35;
            HeSoSucManh = 2.2;
            ManaTieuThu = 7;
        }

        public override double TinhHieuSuat() => TinhSatThuongThucTe() / TinhManaCanThiet();
    }
}
