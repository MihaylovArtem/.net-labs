using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;

namespace Lab1.Employees {
    /// <summary>
    /// Абстрактный класс с интерфейсом IEmployee
    /// </summary>
    public abstract class Employee<T> : IEmployee<T> where T : IComputer {  
        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        public int salary { get; private set; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string position { get; private set; }
        /// <summary>
        /// Компьютер, который закреплен за этим сотрудником
        /// </summary>
        public T computer { get; private set; }

        /// <summary>
        /// Конструктор класса Employee
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="computer"></param>

        
        protected Employee(string Name, string Position, int Salary, T Computer) {
            name = Name;
            position = Position;
            salary = Salary;
            computer = Computer;
        }

        public void performActionWithComputer(Action action)
        {
            action();
            Console.WriteLine("Task completed");
        }
    }
}
