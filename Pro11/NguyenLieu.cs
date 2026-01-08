using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class NguyenLieu
    {
        public string Ten { get; set; }
        public float KhoiLuong { get; set; } // Khối lượng tính bằng gram
        public ThongTinDinhDuong ThongTinDinhDuong { get; set; }

        public NguyenLieu(string ten, float khoiLuong, ThongTinDinhDuong thongTinDinhDuong)
        {
            Ten = ten;
            KhoiLuong = khoiLuong;
            ThongTinDinhDuong = thongTinDinhDuong;
        }

        public ThongTinDinhDuong GetThongTinDinhDuongSauKhiNau()
        {
            // Giả sử hấp thụ 80% dinh dưỡng sau khi nấu
            return new ThongTinDinhDuong(
                ThongTinDinhDuong.Carb * 0.8f,
                ThongTinDinhDuong.Fat * 0.8f,
                ThongTinDinhDuong.FatBaoHoa * 0.8f,
                ThongTinDinhDuong.Protein * 0.8f,
                ThongTinDinhDuong.Calo * 0.8f
            );
        }
        public float GetTongCalo()
        {
            return (ThongTinDinhDuong.Calo * KhoiLuong) / 100;
        }
    }
}
