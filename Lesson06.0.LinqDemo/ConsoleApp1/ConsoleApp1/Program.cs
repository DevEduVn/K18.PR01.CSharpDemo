using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_0_LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Hung", "Dung", "Sang", "Trong" };
            Console.WriteLine("Danh sach ten:");
            IEnumerable<string> ListNames = from x in Names select x;
            foreach (var item in ListNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Danh sach ten co chua ky tu 'un'");
            ListNames = from x in Names
                        where x.Contains("un")
                        select x;
            foreach (var item in ListNames)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
