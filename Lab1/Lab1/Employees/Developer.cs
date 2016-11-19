using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;

namespace Lab1.Employees
{
    [Serializable]
    public class Developer<T> : Employee<T> where T : IComputer
    {
        private const string Position = "Developer";
        private const int Salary = 60000;

        public Developer(string name, T computer) : base(name, Position, Salary, computer) {
            Console.WriteLine("Developer added!");
        }

        public Developer() : base("Noname", "Developer", 10000, default (T))
        {
            
        }
    }
}
