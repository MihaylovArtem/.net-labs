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
    [Serializable]
    public class Manager<T> : Employee<T> where T : IComputer
    {
        private const string Position = "Project manager";
        private const int Salary = 30000;
        /// <summary>
        /// Конструктор класса Manager
        /// </summary>
        /// <param name="name"></param>
        /// <param name="computer"></param>
        public Manager(string name, T computer) : base(name, Position, Salary, computer)
        {
            //Console.WriteLine("Manager added!");
        }

        public Manager() : base("Noname", "Manager", 40000, default(T))
        {
            
        } 
    }
}
