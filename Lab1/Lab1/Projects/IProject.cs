using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;

namespace Lab1.Projects {
    public interface IProject<T> : ICollection<T> where T : IEmployee<IComputer>
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        string name { get; }
        /// <summary>
        /// Участники проекта
        /// </summary>
        List<T> participants { get; }

        /// <summary>
        /// Сортировка команды проекта с указанием поля сортировки
        /// </summary>
        /// <param name="fieldToSort">Параметр, по которому сортируем</param>
        void sortTeam(String fieldToSort);
        /// <summary>
        /// Сортировка команды проекта с указанием порядка сортировки
        /// </summary>
        /// <param name="res">метод-делегат, возвращающий результат сравнения 2 эелементов сортируемого списка</param>
        void customSortTeam(Func<T, T, bool> res);
    }
}
