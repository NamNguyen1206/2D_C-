using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03
{
    internal class Pro02
    {
        static void Main(string[] args)
        {
            string arr = " Le Van Meo";
            arr = arr.Trim();
            arr = arr.ToUpper();
            arr = arr.ToLower();

            Console.WriteLine(arr);
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Contains("Van"));// Kiem tra chuoi "van" co nam trong chuoi arr hay khong, tra ve true hay false
            Console.WriteLine("Vi tri fist :"+ arr.IndexOf("v"));// Tra ve vi tri dau tien tim dc
            Console.WriteLine("Vi tri last :"+ arr.LastIndexOf("v"));// Tra ve vi tri cuoi cung tim dc
            Console.WriteLine("Chuoi con :" + arr.Substring(3));// Lay chuoi con tu vi tri 3
            Console.WriteLine("Chuoi con :" + arr.Substring(0,4));// Lya chuoi con tu vi tri 0 , gom 4 phan tu
            arr = arr.Remove(0, 2);// Xoa tu vi tri thu 0, gom 2 phan tu 
            Console.WriteLine(arr);
            string[] arr2 = arr.Split(' ');
            Console.WriteLine("Danh sach tu");
            foreach(string s in arr2)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }

        
    }
}
