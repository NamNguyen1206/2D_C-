using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    internal abstract class KiNang
    {
        public string TenKN { get; set; }
        public int SatThuong { get; set; }
        public double HeSoSucManh { get; set; }
        public int ManaTieuThu { get; set; }

        // Các phương thức chung cho tất cả kỹ năng
        public double TinhSatThuongThucTe() => SatThuong * HeSoSucManh;
        public double TinhManaCanThiet() => ManaTieuThu * TinhSatThuongThucTe();
        public abstract double TinhHieuSuat();
    }
}
