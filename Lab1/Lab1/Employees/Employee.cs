using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Logger;

namespace Lab1.Employees {
    /// <summary>
    /// Абстрактный класс с интерфейсом IEmployee
    /// </summary>
    public abstract class Employee<T> : IEmployee<T> where T : IComputer
    {

        public event Action<EmployeeActionArgs> OnUninstallProgram;
        public event Action<EmployeeActionArgs> OnInstallProgram;

        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        public uint salary { get; private set; }
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

        
        protected Employee(string Name, string Position, uint Salary, T Computer) {
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

        public void installProgram(string programName)
        {
            if (programName == null)
            {
                throw new UserException("Program name can't be empty");
            }
            OnInstallProgram.Invoke(new EmployeeInstallActionArgs(programName));
        }

        public void uninstallProgram(string programName)
        {
            if (string.IsNullOrEmpty(programName))
            {
                throw new UserException("Program name can't be empty");
            }
            OnUninstallProgram.Invoke(new EmployeeUninstallActionArgs(programName));
        }
    }
}
