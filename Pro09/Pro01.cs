    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro09
{
    internal class Pro01
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DSDG a =new DSDG();
            a.Nhap();
            a.Xuat();
            Console.WriteLine("Danh sach chi tieu nhieu nhat ");
            a.ChiTieuNhieuNhat().Xuat();
            Console.WriteLine("Tổng tiền thu từ độc giả trẻ em: " + a.TongTienDGTreEm());
            Console.ReadKey();
        }
    }
}
