using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class Pro01
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập thông tin dinh dưỡng cho các nguyên liệu
            var thongTinDinhDuongGa = new ThongTinDinhDuong(0, 15, 4, 18, 211);
            var thongTinDinhDuongHatSen = new ThongTinDinhDuong(7, 1, 0, 7, 89);
            var thongTinDinhDuongCaRot = new ThongTinDinhDuong(10, 3, 0, 1, 41);
            var thongTinDinhDuongTaoDo = new ThongTinDinhDuong(3, 0, 1, 1, 52);
            var thongTinDinhDuongNamDongCo = new ThongTinDinhDuong(1, 0, 0, 1, 15);

            // Nhập vào các nguyên liệu
            var ga = new NguyenLieu("Gà", 500, thongTinDinhDuongGa); // 500g gà
            var hatSen = new NguyenLieu("Hạt Sen", 100, thongTinDinhDuongHatSen); // 100g hạt sen
            var caRot = new NguyenLieu("Cà Rốt", 150, thongTinDinhDuongCaRot); // 150g cà rốt
            var taoDo = new NguyenLieu("Tảo Đỏ", 50, thongTinDinhDuongTaoDo); // 50g tảo đỏ
            var namDongCo = new NguyenLieu("Nấm Đông Cô", 50, thongTinDinhDuongNamDongCo); // 50g nấm đông cô

            // Tạo món ăn và thêm nguyên liệu
            var monAn = new PhanAn("Gà Hầm Tảo Đỏ");
            monAn.ThemNguyenLieu(ga);
            monAn.ThemNguyenLieu(hatSen);
            monAn.ThemNguyenLieu(caRot);
            monAn.ThemNguyenLieu(taoDo);
            monAn.ThemNguyenLieu(namDongCo);

            // Nhập vào các chỉ số dinh dưỡng tối đa cho bữa ăn
            var buaAn = new BuaAn(50, 30, 10, 40, 600); // các giá trị max carb, fat, protein, calo

            // Kiểm tra bữa ăn có hợp lý không
            buaAn.KiemTraThongTinDinhDuong(monAn);
            Console.ReadLine();
        }
    }
}
