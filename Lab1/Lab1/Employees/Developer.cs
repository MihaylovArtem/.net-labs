using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Employees
{
    class Developer : EmployeeBase {
        private const string position = "Developer";
        private const int salary = 60000;

        public Developer(string name, string project) : base(name, position, salary, project) {
            Console.WriteLine("Developer added!");
        }
    }
}
