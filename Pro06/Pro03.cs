using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro06
{
    internal class Pro03
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo đối tượng học sinh
            Student student = new Student();

            // Nhập thông tin học sinh
            Console.WriteLine("Nhập họ học sinh:");
            student.LastName = Console.ReadLine();

            Console.WriteLine("Nhập tên học sinh:");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("Nhập tuổi học sinh:");
            student.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Toán:");
            student.MathScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Vật lý:");
            student.PhysicsScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Hóa học:");
            student.ChemistryScore = float.Parse(Console.ReadLine());

            // Xuất thông tin học sinh
            student.DisplayInfo();

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
