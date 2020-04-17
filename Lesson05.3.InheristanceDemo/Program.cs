using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._3.InheristanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call ===> Animal");
            Animal a = new Animal();
            a.Eating();
            a.DoSomething();


            Console.WriteLine("Call ===> Cat");
            Cat c = new Cat();
            c.Action();

            Console.WriteLine("======");
            c.Eating();
            c.DoSomething();


            Console.WriteLine("======");
            a = new Animal();

            //a.Food = "Cá"; //=> Error

            Console.ReadLine();
        }
    }
    /// <summary>
    /// Base clase
    /// </summary>
    class Animal
    {
        // Field
        protected string Food;
        protected string Activity;

        // Method
        public void Eating()
        {
            Console.WriteLine("Animal Eating");
        }
        public void DoSomething()
        {
            Console.WriteLine("Animal Do something");
        }
    }

    class Cat : Animal
    {
        public void Action()
        {
            Cat c = new Cat();
            c.Eating(); // Thực hiện eating trong lớp cat
            DoSomething();   // Được thừa hưởng từ lớp Animal
            base.Eating(); // Được thừa hưởng từ lớp Animal
        }

        public new void Eating()
        {
            Console.WriteLine("Cat eating");
        }
        public void Show()
        {
            Food = "Cá";
            Activity = "abc";
            Console.WriteLine(Food);
            Console.WriteLine(Activity);
        }
    }
}
