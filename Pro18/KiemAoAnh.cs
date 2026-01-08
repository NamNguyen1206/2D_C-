using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    internal class KiemAoAnh: KiNang
    {
        public KiemAoAnh()
        {
            TenKN = "Kiếm Ảo Ảnh";
            SatThuong = 30;
            HeSoSucManh = 1.8;
            ManaTieuThu = 5;
        }

        public override double TinhHieuSuat() => TinhSatThuongThucTe() / TinhManaCanThiet();
    }
}
