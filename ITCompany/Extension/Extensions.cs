using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Projects;
using ITCompany.Employees;
using ITCompany.Computers;
using ITCompany.Logger;
using ITCompany.Serializer;
using Newtonsoft.Json;

namespace Extension {
    static class Extensions {
        /// <summary>
        /// Метод конвертации коллекции в строку формата JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        public static string ConvertToString<T>(this Project<T> project, EventLogger<IEmployee<IComputer>> logger = null) where T : IEmployee<IComputer> {
            var wrapper = new ProjectWrapper<T>(project);
            logger.Log("Converted to string");
            return JsonConvert.SerializeObject(wrapper, Formatting.Indented);
        }
        /// <summary>
        /// Поиск сотрудников по коллекции, у которых имя длиннее 7 символов
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        public static List<T> FindEmployeesWithLongName<T>(this Project<T> project, EventLogger<IEmployee<IComputer>> logger = null) where T : IEmployee<IComputer> {
            logger.Log("Finded all employes with long name");
            return project.Where(t => t.name.Length > 7).ToList();
        }
        /// <summary>
        /// Поиск сотрудников по коллекции, у которых компьютер старше 2014 года
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        public static List<T> FindEmployeesWithOldMacs<T>(this Project<T> project, EventLogger<IEmployee<IComputer>> logger = null) where T : IEmployee<IComputer> {
            logger.Log("Finded all employes with old macs");
            return project.Where(t => t.computer.purchaseYear < 2014).ToList();
        }
    }
}
