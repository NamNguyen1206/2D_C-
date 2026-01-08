using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class BuaAn
    {
        public float MaxCarb { get; set; }
        public float MaxFat { get; set; }
        public float MaxFatBaoHoa { get; set; }
        public float MaxProtein { get; set; }
        public float MaxCalo { get; set; }
        public BuaAn(float maxCarb, float maxFat, float maxFatBaoHoa, float maxProtein, float maxCalo)
        {
            MaxCarb = maxCarb;
            MaxFat = maxFat;
            MaxFatBaoHoa = maxFatBaoHoa;
            MaxProtein = maxProtein;
            MaxCalo = maxCalo;
        }
        public void KiemTraThongTinDinhDuong(PhanAn phanAn)
        {
            var thongTinDinhDuongTongHop = phanAn.GetThongTinDinhDuongTongHop();

            Console.WriteLine($"Tổng hợp thông tin dinh dưỡng cho món {phanAn.Ten}:");
            Console.WriteLine($"Carb: {thongTinDinhDuongTongHop.Carb} g (Tối đa: {MaxCarb} g)");
            Console.WriteLine($"Fat: {thongTinDinhDuongTongHop.Fat} g (Tối đa: {MaxFat} g)");
            Console.WriteLine($"Fat bão hòa: {thongTinDinhDuongTongHop.FatBaoHoa} g (Tối đa: {MaxFatBaoHoa} g)");
            Console.WriteLine($"Protein: {thongTinDinhDuongTongHop.Protein} g (Tối đa: {MaxProtein} g)");
            Console.WriteLine($"Calories: {thongTinDinhDuongTongHop.Calo} kcal (Tối đa: {MaxCalo} kcal)");

            // Tính toán calo dư thừa
            float caloDuThua = thongTinDinhDuongTongHop.Calo - MaxCalo;

            if (caloDuThua > 0)
            {
                // Giả sử chạy bộ đốt khoảng 145-150 calo trong 30 phút (mỗi phút đốt trung bình 4.92 calo)
                float thoiGianChay = caloDuThua / 4.92f;
                Console.WriteLine($"Bạn cần chạy bộ trong {thoiGianChay:F2} phút để đốt hết lượng calo dư thừa.");
            }
            else
            {
                Console.WriteLine("Không cần chạy bộ vì bữa ăn không có calo dư thừa.");
            }
        }
    }
}
