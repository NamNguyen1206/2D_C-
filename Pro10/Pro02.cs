using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10
{
    internal class Pro02
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NongTrai nt = new NongTrai();
            nt.Nhap();
            nt.GiaSucDoi();
            nt.ThongKe();
            Console.ReadLine();
        }
    }
}
