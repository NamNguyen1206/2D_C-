using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class PhanAn
    {
        public string Ten { get; set; }
        public List<NguyenLieu> NguyenLieu { get; set; }
        public PhanAn(string ten)
        {
            Ten = ten;
            NguyenLieu = new List<NguyenLieu>();
        }
        public void ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            NguyenLieu.Add(nguyenLieu);
        }
        public ThongTinDinhDuong GetThongTinDinhDuongTongHop()
        {
            float tongCarb = 0, tongFat = 0, tongFatBaoHoa = 0, tongProtein = 0, tongCalo = 0;
            foreach (var nguyenLieu in NguyenLieu)
            {
                var thongTinDinhDuongSauKhiNau = nguyenLieu.GetThongTinDinhDuongSauKhiNau();
                tongCarb += thongTinDinhDuongSauKhiNau.Carb;
                tongFat += thongTinDinhDuongSauKhiNau.Fat;
                tongFatBaoHoa += thongTinDinhDuongSauKhiNau.FatBaoHoa;
                tongProtein += thongTinDinhDuongSauKhiNau.Protein;
                tongCalo += thongTinDinhDuongSauKhiNau.Calo;
            }
            return new ThongTinDinhDuong(tongCarb, tongFat, tongFatBaoHoa, tongProtein, tongCalo);
        }
    }
}
