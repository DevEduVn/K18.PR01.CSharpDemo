using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gọi thực hiện các biến tĩnh (không thông qua đối tượng, gọi trực tiếp từ lớp)
            Console.WriteLine("PI = " + Calculator.PI);
            Console.WriteLine("Name =  " + Calculator.NameCorp);

            // Gọi thực hiện phương thức tĩnh:
            int x = Calculator.Add(123, 1245);
            Console.WriteLine("x= {0}", x);
            int y = Calculator.Sub(200, 150);
            Console.WriteLine("y= {0}", y);
            //x = Calculator.Mul(200, 150); // Lỗi => Vì Phương thưc Mul không phải là phương thức tĩnh
            Calculator calc = new Calculator();
            x = calc.Mul(100, 200);
            Console.WriteLine("x= {0}", x);

            Console.ReadKey();
        }
    }
}
