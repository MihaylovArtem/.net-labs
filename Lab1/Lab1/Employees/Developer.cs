using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;

namespace Lab1.Employees
{
    class Developer : Employee {
        private const string Position = "Developer";
        private const int Salary = 60000;

        public Developer(string name, string project, IComputer computer) : base(name, Position, Salary, project, computer) {
            Console.WriteLine("Developer added!");
        }
    }
}
