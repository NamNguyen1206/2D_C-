using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class QuanLy
    {
        // Danh sách các gói dịch vụ
        private List<GoiDichVu> goiDichVu;

        // Constructor để khởi tạo các gói dịch vụ
        public QuanLy()
        {
            goiDichVu = new List<GoiDichVu>
            {
                new GoiDichVu("Premium", 1000, 0, true, true),
                new GoiDichVu("Basic", 500, 100, false, true),
                new GoiDichVu("Non-member", 200, 0, false, false)
            };
        }

        // Phương thức hiển thị tất cả các gói dịch vụ
        public void HienThiTatCaGoiDich()
        {
            if (goiDichVu == null || goiDichVu.Count == 0)
            {
                Console.WriteLine("Không có gói dịch vụ để hiển thị.");
                return;
            }

            foreach (var goi in goiDichVu)
            {
                goi.HienThiThongTin();
            }
        }

        // Phương thức cho phép người dùng chọn gói dịch vụ
        public GoiDichVu ChonGoiDichVu()
        {
            Console.WriteLine("Nhập tên gói dịch vụ bạn muốn tham khảo (Premium, Basic, Non-member): ");
            string userInput = Console.ReadLine()?.Trim();

            // Kiểm tra nếu người dùng nhập rỗng
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Tên gói dịch vụ không hợp lệ.");
                return null;
            }

            // Tìm kiếm gói dịch vụ theo tên
            GoiDichVu goiChon = goiDichVu.Find(g => g.TenGoi.Equals(userInput, StringComparison.OrdinalIgnoreCase));

            if (goiChon != null)
            {
                return goiChon;
            }
            else
            {
                Console.WriteLine("Gói dịch vụ không tìm thấy!");
                return null;
            }
        }

        // Phương thức thêm gói dịch vụ mới
        public void ThemGoiDichVu(GoiDichVu goi)
        {
            if (goi != null)
            {
                goiDichVu.Add(goi);
                Console.WriteLine("Gói dịch vụ đã được thêm thành công.");
            }
            else
            {
                Console.WriteLine("Gói dịch vụ không hợp lệ.");
            }
        }

        // Phương thức xóa gói dịch vụ
        public void XoaGoiDichVu(string tenGoi)
        {
            var goiCanXoa = goiDichVu.Find(g => g.TenGoi.Equals(tenGoi, StringComparison.OrdinalIgnoreCase));

            if (goiCanXoa != null)
            {
                goiDichVu.Remove(goiCanXoa);
                Console.WriteLine("Gói dịch vụ đã được xóa.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy gói dịch vụ để xóa.");
            }
        }
    }
}
