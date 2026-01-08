using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro05
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor để khởi tạo vector với tọa độ x và y
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Hàm tính độ dài (module) của vector
        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public static Vector InputVector(string name)
        {
            Console.WriteLine($"Nhập tọa độ vector {name} (x, y):");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            return new Vector(x, y);
        }
        public static void PrintResult(Vector vectorA, Vector vectorB, double magnitudeA, double magnitudeB, Vector sum, Vector difference, double dotProduct, bool arePerpendicular)
            {
                // Xuất kết quả
                Console.WriteLine("\nDanh sách các vector:");
                Console.Write("Vector a = ");
                vectorA.Print();
                Console.Write("Vector b = ");
                vectorB.Print();

                Console.WriteLine($"\nĐộ dài của vector a: {magnitudeA}");
                Console.WriteLine($"Độ dài của vector b: {magnitudeB}");

                Console.WriteLine($"\nTổng của hai vector: ");
                sum.Print();
                Console.WriteLine($"Hiệu của hai vector: ");
                difference.Print();
                Console.WriteLine($"Tích vô hướng của hai vector: {dotProduct}");

                if (arePerpendicular)
                {
                    Console.WriteLine("Hai vector vuông góc với nhau.");
                }
                else
                {
                    Console.WriteLine("Hai vector không vuông góc với nhau.");
                }
            }

        // Hàm tính tổng của hai vector
        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Hàm tính hiệu của hai vector
        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        // Hàm tính tích vô hướng của hai vector
        public static double DotProduct(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        // Hàm kiểm tra hai vector có vuông góc hay không
        public static bool ArePerpendicular(Vector v1, Vector v2)
        {
            return DotProduct(v1, v2) == 0;
        }

        // Hàm in ra thông tin của vector
        public void Print()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }

}

