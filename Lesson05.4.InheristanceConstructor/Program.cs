using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._4.InheristanceConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Cho nhat");
            Console.WriteLine(d.Name);

            Cat c = new Cat("Meo domino");
            Console.WriteLine(c.Name);

            d = new Dog();
            Console.WriteLine("Moi ban nhap ten cho:");
            d.Name = Console.ReadLine();
            Console.WriteLine(d.Name);

            // c = new Cat();
            Console.ReadLine();

        }
    }
    /// <summary>
    /// Base class Animal
    /// </summary>
    class Animal
    {
        // Field:
        public string Name { get; set; }

        // Constructor
        public Animal() { }
        public Animal(string Name)
        {
            this.Name = Name;
        }
    }
    /// <summary>
    /// Derived Class Dog
    /// </summary>
    class Dog : Animal
    {
        //Constructor
        public Dog() : base() { }
        public Dog(string Name) : base(Name)
        {

        }
    }
    class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {

        }
    }
}
