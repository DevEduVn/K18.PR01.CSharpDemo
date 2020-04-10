using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04.PropertiesAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đối tượng Product
            Product p1 = new Product();

            // Gán giá trị 
            p1.Id = 1234;
            p1.Name = "Bia Corona";
            p1.Price = 100000f;
            // p1.Price = 100000f; //=> lỗi (Khi dùng thuộc tính chỉ đọc)
            p1.Quantity = 100;

            // Xuất
            Console.WriteLine("ID \t:" + p1.Id);
            Console.WriteLine("Name \t:" + p1.Name);
            Console.WriteLine("Price \t:" + p1.Price);
            Console.WriteLine("Qty \t:" + p1.Quantity);
            //Console.WriteLine("Qty \t:" + p1.Quantity);// => Error (khi dùng thuộc tính chỉ ghi

            Console.WriteLine("Product Infor:");
            p1.ShowInfor(); // Gọi thực hiện phương thức không tham số.

            // Gọi phương thức có tham số (Add)

            int GiaTri = p1.Add(123, 234);
            Console.WriteLine("Tổng = " + GiaTri);

            // Gọi phương thức có giá trị trả về, không có tham số
            Console.WriteLine("Thành tiền: " + p1.TotalMoney());
            Console.ReadKey();
        }
    }

    // Tạo lớp với các thuộc tính tự động
    public class Product
    {
        // Khai báo các thuộc tính tự động cho lớp Product
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get;  set; }
        public int Quantity {  get; set; }
        // public double Price { get; private set; } // Thuộc tính chỉ đọc
        // public int Quantity { private get; set; } // Thuộc tính chỉ ghi

        // Tạo các phương thức cho lớp đối tượng Product
        // Phương thức không có tham số, không có giá trị trả về xác định
        public void ShowInfor()
        {
            Console.WriteLine("| {0,-5} | {1,15} | {2,10} | {3,10} |", Id, Name, Price, Quantity);
        }
        // Tạo một phương có tham số [int Add (int a, int b)]
        public int Add(int a, int b)
        {
            return a + b;
        }
        // Tạo phương thức tính thành tiền cho sản phẩm Price * Quantity
        public double TotalMoney()
        {
            return Price * Quantity;
        }
    }
}
