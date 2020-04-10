using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession04
{
    class Employees
    {
        // Field (Trường lưu trữ dữ liệu)
        private int _ID;
        public string _FullName;
        public float _Salary;

        // Properties (Thuộc tính) 
        // Thuộc tính đọc / ghi
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        // Thuộc tính chỉ đọc
        public string FullName
        {
            get { return _FullName; }
        }
            
        // Thuộc tính chỉ ghi
        public float Salary
        {
            set { _Salary = value; }
        }
    }
}
