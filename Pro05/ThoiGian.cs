using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro05
{
    internal class ThoiGian
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        // Constructor để khởi tạo đối tượng ThoiGian với giờ, phút, giây
        public ThoiGian(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        // Phương thức chuyển mốc thời gian thành số giây
        public int ToSeconds()
        {
            return Hour * 3600 + Minute * 60 + Second;
        }

        // Phương thức hiển thị thời gian dưới dạng "giờ:phút:giây"
        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }

        // Phương thức static nhập thời gian
        public static ThoiGian InputTime(string message)
        {
            Console.WriteLine(message);
            string[] parts = Console.ReadLine().Split(':');
            int h = int.Parse(parts[0]);
            int m = int.Parse(parts[1]);
            int s = int.Parse(parts[2]);
            return new ThoiGian(h, m, s);
        }

        // Phương thức static xuất thời gian
        public static void DisplayTime(ThoiGian t)
        {
            Console.WriteLine(t.ToString());
        }

        // Phương thức tính khoảng cách giữa hai mốc thời gian
        public static ThoiGian GetDifference(ThoiGian t1, ThoiGian t2)
        {
            int diffInSeconds = Math.Abs(t1.ToSeconds() - t2.ToSeconds());

            // Quy đổi hiệu giây thành giờ, phút, giây
            int hours = diffInSeconds / 3600;
            int minutes = (diffInSeconds % 3600) / 60;
            int seconds = diffInSeconds % 60;

            return new ThoiGian(hours, minutes, seconds);
        }

        // Phương thức static so sánh hai mốc thời gian
        public static void CompareTimes(ThoiGian time1, ThoiGian time2)
        {
            // Hiển thị các mốc thời gian
            Console.WriteLine($"Mốc thời gian thứ nhất: {time1}");
            Console.WriteLine($"Mốc thời gian thứ hai: {time2}");

            // So sánh hai mốc thời gian
            if (time1.ToSeconds() > time2.ToSeconds())
            {
                Console.WriteLine("→ Mốc thời gian thứ nhất lớn hơn.");
            }
            else if (time1.ToSeconds() < time2.ToSeconds())
            {
                Console.WriteLine("→ Mốc thời gian thứ hai lớn hơn.");
            }
            else
            {
                Console.WriteLine("→ Hai mốc thời gian bằng nhau.");
            }

            // Tính và hiển thị khoảng cách giữa hai mốc thời gian
            ThoiGian difference = GetDifference(time1, time2);
            Console.WriteLine($"Khoảng cách giữa hai mốc thời gian là: {difference.Hour} giờ {difference.Minute} phút {difference.Second} giây.");
        }
    }
}

