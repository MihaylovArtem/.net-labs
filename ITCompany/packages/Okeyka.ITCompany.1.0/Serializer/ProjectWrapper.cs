using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lab1.Computers;
using Lab1.Employees;
using Lab1.Projects;

namespace Lab1.Serializer {
    /// <summary>
    /// обертка для класса-коллекции (используется для сериализации)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class ProjectWrapper<T> where T : IEmployee<IComputer>
    {
        [XmlAttribute]
        public string name { get; set; }
        public List<T> participants { get; set; }

        public ProjectWrapper(Project<T> project )
        {
            name = project.name;
            participants = project.participants;
        }

        public ProjectWrapper()
        {
            
        }  
    }
}
