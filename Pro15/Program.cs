using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro15
{
    internal class Program
    {   
            delegate void ShowMessage(string message);
            static void XuatTen1(string name)
            {
                Console.WriteLine("Ten cua ban la: " + name);
            }
            static void XuatTen2(string name)
            {

               Console.WriteLine("Ten cua ban la: " + name);
            }
        delegate int Calc (int a, int b);
            static int Tong(int a, int b)=> a + b;
            static int Tich(int a, int b) => a * b;
            
        static void Main(string[] args)
        {
            //    int a = 0, b = 0;
            //try
            //{
            //    Console.WriteLine("Nhap a va b: ");
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    int result = a / b;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Loi chia cho 0: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine($"a={a} va b = {b}");
            //}
            //try
            //{
            //    int[] arr = { 1, 2, 3 };
            //    Console.WriteLine("Nhap vi tri index: ");
            //    int index = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"a[{index}] = {arr[index]}");
            //}
            //catch
            //{
            //    Console.WriteLine("Gia tri index vuot qua gioi han mang.");
            //}
            //try
            //{
            //    Console.WriteLine("Nhap 1 so nguyen: ");
            //    string input = Console.ReadLine();
            //    int number = int.Parse(input);
            //    Console.WriteLine($"So vua nhap la: {number}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Loi dinh dang: " + ex.Message);
            //}
            //ShowMessage show = XuatTen1;
            //show("Le Meo");
            //show("Le Giang");
            //Calc calc = Tong;
            //Console.WriteLine("Tong: " + calc(5, 10));
            //calc = Tich;
            //Console.WriteLine("Tich: " + calc(5, 10));
            ItemCollector a = new ItemCollector();
            ItemCollector b = new ItemCollector();
            a.OnTriggerEnter(true);
            b.OnTriggerEnter(true);
            Console.ReadKey();
        }
    }
}
