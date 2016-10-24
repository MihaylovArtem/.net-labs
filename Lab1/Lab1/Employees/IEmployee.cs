using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;

namespace Lab1.Employees
{
    /// <summary>
    /// Интерфейс класса Employee
    /// </summary>
    public interface IEmployee<out T> where T : IComputer {

        /// <summary>
        /// Событие удаления программы
        /// </summary>
        event Action<EmployeeActionArgs> OnUninstallProgram;
        /// <summary>
        /// Событие удаления программы
        /// </summary>
        event Action<EmployeeActionArgs> OnInstallProgram;
        
        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        uint salary { get; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        string name { get; }
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        string position { get; }
        /// <summary>
        /// Проект, в котором участвует сотрудник
        /// </summary>
        T computer { get; }
        /// <summary>
        /// Выполнить действие над компьютером
        /// </summary>
        /// <param name="action">выполняемое действие</param>
        void performActionWithComputer(Action action);

        /// <summary>
        /// Установка программы
        /// </summary>
        /// <param name="programName">Название программы</param>
        void installProgram(string programName);
        /// <summary>
        /// Удаление программы
        /// </summary>
        /// <param name="programName">Название программы</param>
        void uninstallProgram(string programName);
    }
}
