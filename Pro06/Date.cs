using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro06
{
    internal class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public void InputDate()
        {
            Console.Write("Nhập ngày: ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm: ");
            Year = int.Parse(Console.ReadLine());
        }
        public Date NextDay()
        {
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
            {
                daysInMonth[2] = 29;
            }

            int nextDay = Day + 1;
            int nextMonth = Month;
            int nextYear = Year;

            if (nextDay > daysInMonth[Month])
            {
                nextDay = 1;
                nextMonth++;
                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            return new Date { Day = nextDay, Month = nextMonth, Year = nextYear };
        }
        public Date PreviousDay()
        {
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
            {
                daysInMonth[2] = 29;
            }

            int prevDay = Day - 1;
            int prevMonth = Month;
            int prevYear = Year;

            if (prevDay < 1)
            {
                prevMonth--;
                if (prevMonth < 1)
                {
                    prevMonth = 12;
                    prevYear--;
                }
                prevDay = daysInMonth[prevMonth];
            }

            return new Date { Day = prevDay, Month = prevMonth, Year = prevYear };
        }
        public void OutputDate()
        {
            Console.WriteLine($"Ngày đã nhập là: {Day}/{Month}/{Year}");
        }
    }
}
