using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04.Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp01 = new Employees(); // Khởi tạo đối tượng với hàm tạo không tham số
            emp01.ShowInfor();

            emp01 = new Employees(1001, "Chung Trinh Van", 123456); // Khởi tạo đối tượng với hàm tạo có tham số
            emp01.ShowInfor();

            Console.ReadKey();
        }
    }

    class Employees
    {
        // Field
        private int _ID;
        private string _FullName;
        private double _Salary;

        // Hàm khởi tạo ( Là một phương thức có tên cùng với tên lớp)
        public Employees() // Hàm khởi tạo không tham số
        {
            _ID = 1000;
            _FullName = "HPC_";
            _Salary = 100;
        }

        public Employees(int ID, string FullName, double Salary)
        {
            _ID = ID;
            _FullName = FullName;
            _Salary = Salary;
        }

        // Phương thức hiển thị
        public void ShowInfor()
        {
            Console.WriteLine("{0,-10} | {1,-20} | {2,15}", _ID, _FullName, _Salary);
        }

        // Hàm hủy
        ~Employees()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
