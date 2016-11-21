using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Computers;
using ITCompany.Employees;
using ITCompany.Projects;

namespace ITCompany.Serializer {
    interface ISerializer<T> where T : IEmployee<IComputer>
    {
        /// <summary>
        /// Десериализовать файл
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <returns>Результат десериализации</returns>
        Project<T> deserialize(string filePath);
        /// <summary>
        /// Сериализовать в файл
        /// </summary>
        /// <param name="project">Предмет сериализации</param>
        /// <param name="filePath">путь к файлу</param>
        void serialize(Project<T> project, string filePath);
    }
}
