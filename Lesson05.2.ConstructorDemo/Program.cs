using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._2.ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng sinh viên
            Student obj = new Student();
            obj.ShowInfo();

            obj = new Student(112202, "Tran Huynh Duc");
            obj.ShowInfo();

            obj = new Student(1234, "Van Phu", 20);
            obj.ShowInfo();

        }
    }
    /// <summary>
    /// Nạp chồng constructor (Overloading)
    /// 
    /// </summary>
    class Student
    {
        // Properties
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor (Overloading)
        public Student() { }
        public Student(int RollNo,string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }
        public Student(int RollNo, string Name, int Age)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Age = Age;
        }
        // Show
        public void ShowInfo()
        {
            Console.WriteLine("RollNo \t:" + RollNo);
            Console.WriteLine("Name \t:" + Name);
            Console.WriteLine("Age \t:" + Age);
        }
    }
}
