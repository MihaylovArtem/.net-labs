using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Computers;
using ITCompany.Employees;
using ITCompany.Projects;

namespace ITCompany.Serializer {
    public class BinarySerializer<T> : ISerializer<T> where T : IEmployee<IComputer>
    {
        private readonly BinaryFormatter formatter;

        public BinarySerializer()
        {
            formatter = new BinaryFormatter();
        }
        public Project<T> deserialize(string path)
        {
            var fileStream = new FileStream(path, FileMode.Open);
            var wrapper = (ProjectWrapper<T>) formatter.Deserialize(fileStream);
            fileStream.Close();
            return new Project<T>(wrapper.name, wrapper.participants);
        }

        public void serialize(Project<T> project, string filePath)
        {
            var fileStream = new FileStream(filePath, FileMode.Create);
            var wrapper = new ProjectWrapper<T>(project);
            formatter.Serialize(fileStream, wrapper);
            fileStream.Close();
        }
    }
}
