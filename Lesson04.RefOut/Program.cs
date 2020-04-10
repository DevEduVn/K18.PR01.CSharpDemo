using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04.RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100, y = 200;
            Console.WriteLine("Trước: x={0}, y={1}", x, y);
            // Gọi Swap
            Number.Swap(x, y);
            Console.WriteLine("Sau: x={0}, y={1}", x, y);

            Console.ReadKey();
            Console.WriteLine("Trước: x={0}, y={1}", x, y);
            // Gọi Swap
            Number.Swap(ref x, ref y);
            Console.WriteLine("Sau: x={0}, y={1}", x, y);
            
            Console.ReadKey();

            // Gọi phương thức có tham số out
            double Chu_Vi;
            Number.ChuVi(out Chu_Vi, 12);
            Console.WriteLine("Chu vi hình tròn có bán kính (12) là:" + Chu_Vi);
            Console.ReadKey();
        }
    }

    class Number
    {
        public static void Swap(int a, int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        // Sử dung ref
        public static void Swap(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        // Sử dụng out
        public static void ChuVi(out double area, double r)
        {
            area = 2 * 3.1415 * r ;
        }
    }
}
