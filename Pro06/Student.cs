using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro06
{
    internal class Student
    {
        // Thuộc tính của học sinh
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float MathScore { get; set; }
        public float PhysicsScore { get; set; }
        public float ChemistryScore { get; set; }

        // Phương thức tính điểm trung bình
        public float GetAverageScore()
        {
            return (MathScore + PhysicsScore + ChemistryScore) / 3;
        }

        // Phương thức xác định kết quả học tập
        public string GetResult()
        {
            return GetAverageScore() >= 5 ? "Đậu" : "Thi lại";
        }

        // Phương thức xuất thông tin học sinh
        public void DisplayInfo()
        {
            Console.WriteLine("\nThông tin học sinh:");
            Console.WriteLine($"Họ và tên: {LastName} {FirstName}");
            Console.WriteLine($"Tuổi: {Age}");
            Console.WriteLine($"Điểm trung bình: {GetAverageScore():F2}");
            Console.WriteLine($"Kết quả: {GetResult()}");
        }
    }
}
