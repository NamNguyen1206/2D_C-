using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro14
{
    internal class QuanLy
    {
        // Phương thức nhập danh sách các nhân vật
       
            List<NhanVat> characters = new List<NhanVat>();
        static NhanVat TaoNhanVat(int type)
        {
            switch (type)
            {
                case 1: return new Ryu();
                case 2: return new ArmorSwordMan();
                case 3: return new Banshee();
                case 4: return new BatMan();
                case 5: return new Bomberhead();
                default : return null;
            }
        }
        public void InputNhanVat()
        {
            Console.WriteLine("Nhập số lượng nhân vật:");
            int numCharacters = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCharacters; i++)
            {
                Console.WriteLine("n1.Ryu 2.ArmorSwordMan 3.Banshee 4.BatMan 5.Bomberhead");
                Console.Write("Chon loai:");
                int type = int.Parse(Console.ReadLine());
                NhanVat c = TaoNhanVat(type);
                Console.Write("Nhap x: ");
                c.X = int.Parse(Console.ReadLine());
                Console.Write("Nhap y: ");
                c.Y = int.Parse(Console.ReadLine());
                characters.Add(c);
            }
        }

        public void KiemTraVaCham()
        {
            Console.WriteLine("Nhap vi tri x (thu tu nhan vat)");
            int idx = int.Parse(Console.ReadLine()) - 1;

            NhanVat Taget = characters[idx];
            NhanVat firsCollide = null;
            foreach (NhanVat c in characters) 
            {
                if (c != Taget && Taget.IsCollide(c))
                {
                    firsCollide = c;
                    break;
                }
            }
            if (firsCollide != null)
            {
                Console.WriteLine("\nNhan vat va cham dau tien:" + firsCollide);
                int count = 0;
                foreach (NhanVat c in characters)
                    if (c.GetType() == firsCollide.GetType())
                        count++;
                Console.WriteLine("So luong nhan vat cung loai: " + count);
            }
            else
            {
                int count = 0;
                foreach (NhanVat c in characters)
                    if (c != Taget&& c.GetType() == Taget.GetType())
                        count++;
                Console.WriteLine("\nKhong va cham ");
                Console.WriteLine("So luong nhan vat cung loai voi nhan vat thu x:" + count);
            }
        }
    }
}
