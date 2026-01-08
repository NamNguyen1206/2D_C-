using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro09
{
    internal class DSDG
    {
        private List<DocGiaTreEm> danhSachTreEm = new List<DocGiaTreEm>();
        private List<DocGiaNguoiLon> danhSachNguoiLon = new List<DocGiaNguoiLon>();
        List<DocGia> ds=new List<DocGia>();
        public void Nhap()
        {
            Console.Write("Nhập số lượng độc giả tre em: ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine($"\nNhập độc giả thứ {i + 1}");
                DocGiaTreEm a = new DocGiaTreEm();
                a.Nhap();
                this.ds.Add(a);
            }
            Console.Write("\nNhập số lượng độc giả nguoi lon: ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine($"\nNhập độc giả thứ {i + 1}");
                DocGiaNguoiLon a = new DocGiaNguoiLon();
                a.Nhap();
                this.ds.Add(a);
            }
        }
        public void Xuat()
        {   
            // Xuất danh sách
            Console.WriteLine("\n===== DANH SÁCH ĐỘC GIẢ =====");
            foreach (DocGia a in ds)
            {
                a.Xuat();
                Console.WriteLine("------------------");
            }
        }
        public DSDG ChiTieuNhieuNhat()
        {
            // Tìm độc giả chi tiêu nhiều nhất
            DSDG kq = new DSDG();
            double max = 0;
            foreach (DocGia a in this.ds)
            {
                if (a.TinhTien() > max)
                    max = a.TinhTien();
            }
            foreach (DocGia b in this.ds)
            {
                if (b.TinhTien() == max)
                    kq.ds.Add(b);
            }
            return kq;
            
        }
        public double TongTienDGTreEm()
        {
            // Tính tổng tiền độc giả trẻ em
            double tong = 0;
            foreach (DocGia a in danhSachTreEm)
            {
                if (a.GetType() == typeof(DocGiaTreEm))
                {
                    tong += a.TinhTien();
                }
            }
            return tong;
        }
    }
}
