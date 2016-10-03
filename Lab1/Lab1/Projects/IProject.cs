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
    }
}
