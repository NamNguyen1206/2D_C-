using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10
{
    internal class NongTrai
    {
        private List<GiaSuc> danhSach = new List<GiaSuc>();

        public NongTrai()
        {
            danhSach.Add(new Bo());
            danhSach.Add(new Cuu());
            danhSach.Add(new De());
        }

        public void Nhap()
        {
            foreach (GiaSuc gs in danhSach)
                gs.Nhap();
        }

        public void GiaSucDoi()
        {
            Console.WriteLine("\n--- Tiếng kêu khi đói ---");
            foreach (GiaSuc gs in danhSach)
                Console.WriteLine(gs.Keu());
        }

        public void ThongKe()
        {
            int tongCon = 0;
            int tongSua = 0;

            foreach (GiaSuc gs in danhSach)
            {
                tongCon += gs.SinhCon();
                tongSua += gs.ChoSua();
            }

            Console.WriteLine("\n--- Thống kê ---");
            Console.WriteLine($"Tổng số con sinh: {tongCon}");
            Console.WriteLine($"Tổng sữa thu được: {tongSua} lít");
        }
    }
}
