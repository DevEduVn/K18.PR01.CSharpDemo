using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một đối tượng từ lớp
            Student objStudent = new Student();

            objStudent.ShowInfor(); // Gọi thực hiện hành động của đối tượng
            //Gán giá trị cho các thuộc tính
            objStudent.RollNo = "SV0123123";
            objStudent.FullName = "Chung Trinhj";
            objStudent.BirthDay = DateTime.Parse("2000/04/10");
            objStudent.Address = "123 Phố Ăn Uống, Hà Nội";

            objStudent.ShowInfor();


            Student HuynhDuc = new Student();
            Console.ReadLine();

        }
    }
    // Lớp, xây dựng lớp
    public class Student
    {
        // Field (Thông tin lưu trữ của đối tượng)
        private string _rollNo;
        private string _fullName;
        private DateTime _birthDay;
        private string _address;

        // Properties (Các thuộc tính của đối tượng)
        public string RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }
        public string FullName {
            get { return _fullName; } 
            set { _fullName = value; } 
        }
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        // Method  (Các hành động của đối tượng)
        public void ShowInfor()
        {
            Console.WriteLine("RollNo  \t:" + RollNo);
            Console.WriteLine("FullName  \t:" + FullName);
            Console.WriteLine("Birthday  \t:" + BirthDay);
            Console.WriteLine("Address  \t:" + Address);
        }
    }
}
