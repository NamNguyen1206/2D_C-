using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro16
{
    internal class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            List<string> MyList = new List<string>();
            //int a = 5; int b = 5;
            //double c = 1.2, d = 5.6;
            //Swap<int>(ref a, ref b);
            //Swap<double>(ref c, ref d);
            //Console.WriteLine("a= + " + a);
            //Console.WriteLine("b= + " + b);
            //Console.WriteLine("c= + " + c);
            //Console.WriteLine("d= + " + d);
            MyList.Add("Freedom");
            MyList.Add("CodeMap");
            MyList.Insert(MyList.Count, "Camping");
            Console.WriteLine(" List ban dau: ");
            Console.WriteLine(" So luong phan tu trong List la: {0}", MyList.Count);
            foreach (string item in MyList)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            //MyList.LastIndexOf("Code");
            MyList.Remove("Camping");
            MyList.Reverse();
            //MyList.Sort();
            //MyList.Clear();
            MyList.Contains("CodeMap");
            //MyList.CopyTo(new string[MyList.Count], 0);
            Console.Write(" List sau khi thay doi la: {0}", MyList.Count);
            foreach (string item in MyList)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.WriteLine(" Vi tri cua CodeMap trong List la: {0}", MyList.IndexOf("CodeMap"));
            Console.WriteLine("==================================================================");
            Dictionary<string, string> MyDic = new Dictionary<string, string>();
            MyDic.Add("FE", "Free Education");
            MyDic.Add("K", "green");
            MyDic.Add("HK", "greenacademy");
            Console.WriteLine(" List ban dau: ");
            foreach (KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            MyDic.Remove("K");
            MyDic["HK"] = "CodeMap";
            MyDic.Add("C", "Camping");
            MyDic.ContainsKey("FE");
            MyDic.TryGetValue("HK", out string value);
            Console.WriteLine(" List sau thay doi : ");
            foreach (KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine("==================================================================");
            // Tạo 1 Queue rỗng
            Queue MyQueue = new Queue();

            // Thực hiện thêm vài phần tử vào Queue thông qua hàm Enqueue.
            MyQueue.Enqueue("1");
            MyQueue.Enqueue("2");
            MyQueue.Enqueue("3");
            // Thử sử dụng các phương thức của Queue.
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", MyQueue.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Queue thì ta sẽ dùng Peek.
            Console.WriteLine(" Phan tu dau cua Queue la: {0}", MyQueue.Peek());
            int Length = MyQueue.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + MyQueue.Dequeue());
            }
            Console.WriteLine();
            int Lg = 0;
            if (MyQueue.Count > 0)
            {
                // Thực hiện xoá các phần tử ra khỏi Queue thông qua hàm Dequeue
                Lg = Convert.ToInt32(MyQueue.Dequeue());
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
            for (int i = 0; i < Lg; i++)
            {
                Console.Write(" " + MyQueue.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
