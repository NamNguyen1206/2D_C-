using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    internal class LuaHuyDiet: KiNang
    {
        public LuaHuyDiet()
        {
            TenKN = "Lửa Hủy Diệt";
            SatThuong = 40;
            HeSoSucManh = 1.5;
            ManaTieuThu = 5;
        }

        // Override phương thức TinhHieuSuat cho kỹ năng này
        public override double TinhHieuSuat() => TinhSatThuongThucTe() / TinhManaCanThiet();    
    }
}
