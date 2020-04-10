using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04.Static
{
    class Calculator
    {
        // Biến tính
        public static double PI = 3.1415;
        public static string NameCorp = "HPC";

        // Static Method
        public static void ShowInfo()
        {
            Console.WriteLine("Welcome to, " + NameCorp);
        }

        // Static Method
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }

        // Method (Non - Static)
        public int Mul(int a, int b)
        {
            return a * b;
        }

    }
}
