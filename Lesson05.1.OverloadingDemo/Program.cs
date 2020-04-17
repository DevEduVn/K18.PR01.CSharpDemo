using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._1.OverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test
            // Call Sum
            int KQ = NapChong.Sum(10);
            Console.WriteLine(KQ);

            KQ = NapChong.Sum(10, 20);
            Console.WriteLine(KQ);

            KQ = NapChong.Add(10, 20);
            Console.WriteLine(KQ);
            
            float KQ1 = NapChong.Add(10.2F, 20.2F);
            Console.WriteLine(KQ1);

            Console.ReadKey();

        }
    }
    /// <summary>
    /// Khái niệm đa hình trong lập trình hướng đối tượng 
    /// Overloading method:
    ///     - Cùng tên
    ///         - Khác nhau về số lượng tham số
    ///         - khác nhau về kiểu dữ liệu của các tham số
    /// </summary>
    class NapChong
    {
        // sum
        public static int Sum(int a)
        {
            //Tính tổng các số  nguyên tư 1-num
            int Tong = 0;
            for (int i = 0; i < a; i++)
            {
                Tong += i;
            }

            return Tong;
        }
        //Sum (int a, int b)
        public static int Sum(int a, int b)
        {
            //Tính tổng các số  nguyên tư 1-num
            int Tong = 0;
            for (int i = a; i < b; i++)
            {
                Tong += i;
            }
            return Tong;
        }
        //Add (a,b)
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static float Add(float a, float b)
        {
            return a + b;
        }
    }
}
