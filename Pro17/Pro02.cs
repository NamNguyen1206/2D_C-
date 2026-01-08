using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro17
{
    class student
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    internal class Pro02
    {
        //static void Main(string[] args)
        //{
        //    List<student> students = new List<student>
        //    {
        //        new student { name = "Alice", age = 18 },
        //        new student { name = "Bob", age = 20 },
        //        new student { name = "Charlie", age = 17 },
        //    };

        //    var ds = students.Where(s => s.age >= 18);
        //    foreach (var s in ds)
        //    {
        //        Console.WriteLine($"Name: {s.name}, Age: {s.age}");
        //    }
        //    var ds2 = students.Select(s => s.age);
        //    foreach (var name in ds)
        //    {
        //        Console.WriteLine(name);
        //    }
        //    var sortedStudents = students.OrderBy(s => s.age);
        //    foreach (var s in sortedStudents)
        //    {
        //        Console.WriteLine($"Name: {s.name}, Age: {s.age}");
        //    }
        //    var result = from s in students
        //                 where s.age >= 18
        //                 orderby s.age
        //                 select s.name;
        //    foreach (var name in result)
        //    {
        //       Console.WriteLine(name);
        //    }
        //    Console.ReadKey();
        //}
    }
}
