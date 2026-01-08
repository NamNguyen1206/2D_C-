using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro05
{
    internal class Pro02
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập dữ liệu
            ThoiGian time1 = ThoiGian.InputTime("Nhập mốc thời gian thứ nhất (giờ:phút:giây):");
            ThoiGian time2 = ThoiGian.InputTime("Nhập mốc thời gian thứ hai (giờ:phút:giây):");

            // So sánh và tính khoảng cách
            ThoiGian.CompareTimes(time1, time2);
            Console.ReadKey();
        }
    }
}
