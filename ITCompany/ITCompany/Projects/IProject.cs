using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Computers;
using ITCompany.Employees;

namespace ITCompany.Projects {
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
        /// Асинхронная сортировка с подсчетом прогресса
        /// </summary>
        /// <param name="progress">Прогресс</param>
        /// <returns></returns>
        Task asyncSortWithProg(IProgress<int> progress);
    }
}
