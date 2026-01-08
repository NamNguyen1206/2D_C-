using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    internal class LuoiHaiBongToi: KiNang
    {
        public LuoiHaiBongToi()
        {
            TenKN = "Lưỡi Hái Bóng Tối";
            SatThuong = 45;
            HeSoSucManh = 2.5;
            ManaTieuThu = 8;
        }
        public override double TinhHieuSuat() => TinhSatThuongThucTe() / TinhManaCanThiet();
    }
}
