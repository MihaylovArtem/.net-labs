using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lab1.Computers;
using Lab1.Employees;
using Lab1.Projects;

namespace Lab1.Serializer {
    class XmlSerializer<T> : ISerializer<T> where T: IEmployee<IComputer>
    {
        private readonly XmlSerializer formatter;

        public XmlSerializer()
        {
            formatter = new XmlSerializer(typeof(ProjectWrapper<T>));
        }

        public void serialize(Project<T> project, string filePath)
        {
            var wrapper = new ProjectWrapper<T>(project);
            var fileStream = new FileStream(filePath, FileMode.Create);
            formatter.Serialize(fileStream, wrapper);
            fileStream.Close();
        }

        public Project<T> deserialize(string filePath)
        {
            var fileStream = new FileStream(filePath, FileMode.Open);
            var wrapper = (ProjectWrapper<T>) formatter.Deserialize(fileStream);
            return new Project<T>(wrapper.name, wrapper.participants);
        } 
    }
}
