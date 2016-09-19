using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;

namespace Lab1.Employees
{
    /// <summary>
    /// Класс-потомок абстрактного класса Employee
    /// </summary>
    public class Manager : Employee
    {
        private const string Position = "Project manager";
        private const int Salary = 30000;
        /// <summary>
        /// Конструктор класса Manager
        /// </summary>
        /// <param name="name"></param>
        /// <param name="project"></param>
        /// <param name="computer"></param>
        public Manager(string name, string project, IComputer computer) : base(name, Position, Salary, project, computer)
        {
            Console.WriteLine("Manager added!");
        }
    }
}
