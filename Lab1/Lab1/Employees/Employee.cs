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
    public abstract class Employee : IEmployee {
        /// <summary>
        /// Проект, в котором участвует сотрудник
        /// </summary>
        public string project
        {
            get { return _project; }
            set {
                if (value != null) {
                    _project = value;
                }
            }
        }
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
        public IComputer computer { get; private set; }
        private string _project;
        /// <summary>
        /// Конструктор класса Employee
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="Project"></param>
        /// <param name="computer"></param>
        protected Employee(string Name, string Position, int Salary, string Project, IComputer computer) {
            name = Name;
            position = Position;
            salary = Salary;
            project = Project;
        }
    }
}
