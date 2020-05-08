using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._1.LinqExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SanPham> ListSanPham = new List<SanPham>
            {
                new SanPham(){ID=100,Name="Iphone",Price = 1000},
                new SanPham(){ID=101,Name="Nokia",Price = 2000},
                new SanPham(){ID=102,Name="Kia",Price = 2500},
                new SanPham(){ID=103,Name="Bphone",Price = 3000},
                new SanPham(){ID=104,Name="Sumsung",Price = 1500}
            };
            Console.WriteLine("Danh sach san pham");
            foreach (var item in ListSanPham)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
            Console.WriteLine("Danh sach san pham co gia <=2000");
            var ListSPPrice = from x in ListSanPham
                              where x.Price <= 2000
                              select x;
            foreach (var item in ListSPPrice)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

            Console.WriteLine("Danh sach san pham co gia <=2000");
            var ListSPE = ListSanPham.Where(x => x.Price <= 2000);
            foreach (var item in ListSPE)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

            // copy thuw

            // Data source 
            List<string> my_list = new List<string>()
            {
                    "This is my Dog",
                    "Name of my Dog is Robin",
                    "This is my Cat",
                    "Name of the cat is Mewmew"
            };

            // Creating LINQ Query 
            var res = from l in my_list
                      where l.Contains("my")
                      select l;

            // Executing LINQ Query 
            foreach (var q in res)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }
    }

    class SanPham
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return string.Format("\t{0,-10}{1,-20}{2,15}", ID, Name, Price);
        }
    }
}
