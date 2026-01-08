using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class GoiDichVu
    {
        // Các thuộc tính của gói dịch vụ
        public string TenGoi { get; set; }
        public int PhiCoBan { get; set; }
        public int PhiLopHoc { get; set; }
        public bool LopHocMienPhi { get; set; }
        public bool HoTroPT { get; set; }
        public GoiDichVu(string tenGoi, int phiCoBan, int phiLopHoc, bool lopHocMienPhi, bool hoTroPT)
        {
            TenGoi = tenGoi;
            PhiCoBan = phiCoBan;
            PhiLopHoc = phiLopHoc;
            LopHocMienPhi = lopHocMienPhi;
            HoTroPT = hoTroPT;
        }
        // Hàm hiển thị thông tin chi tiết của gói dịch vụ
        public void HienThiThongTin()
        {
            Console.WriteLine($"Gói dịch vụ: {TenGoi}");
            Console.WriteLine($"Phí cơ bản: {PhiCoBan:N0} nghìn VND");
            Console.WriteLine($"Phí lớp học: {PhiLopHoc:N0} nghìn VND");
            Console.WriteLine($"Lớp học miễn phí: {(LopHocMienPhi ? "Có" : "Không")}");
            Console.WriteLine($"Hỗ trợ PT (Huấn luyện viên cá nhân): {(HoTroPT ? "Có" : "Không")}");
            Console.WriteLine();
        }
        // Hàm tính toán tổng chi phí (bao gồm phí cơ bản và phí lớp học, trừ lớp học miễn phí nếu có)
        public int TinhTongChiPhi()
        { 
            int tongChiPhi = PhiCoBan + PhiLopHoc;

            // Nếu lớp học miễn phí, không tính phí lớp học
            if (LopHocMienPhi)
            {
                tongChiPhi -= PhiLopHoc; // Giảm phí lớp học nếu lớp học miễn phí
            }

            return tongChiPhi;
        }
    }
}
