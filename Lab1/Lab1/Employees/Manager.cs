using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Employees
{
    public class Manager : EmployeeBase
    {
        private const string position = "Project manager";
        private const int salary = 30000;
        public Manager(string name, string project) : base(name, position, salary, project)
        {
            Console.WriteLine("Manager added!");
        }
    }
}
