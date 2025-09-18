using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Employee
    {
        private string name;  // Tên nhân viên

        // Constructor
        public Employee(string name)
        {
            this.name = name;
        }

        // Phương thức trả về tên nhân viên
        public string GetName()
        {
            return name;
        }
    }
}
