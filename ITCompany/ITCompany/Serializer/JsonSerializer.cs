using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Computers;
using ITCompany.Employees;
using ITCompany.Projects;
using Newtonsoft.Json;

namespace ITCompany.Serializer {
    public class JsonSerializer<T> : ISerializer<T> where T : IEmployee<IComputer>
    {
        public Project<T> deserialize(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var wrapper = JsonConvert.DeserializeObject<ProjectWrapper<T>>(json);
            return new Project<T>(wrapper.name, wrapper.participants);
        }

        public void serialize(Project<T> project, string filePath)
        {
            var wrapper = new ProjectWrapper<T>(project);
            var json = JsonConvert.SerializeObject(wrapper);
            File.WriteAllText(filePath, json);
        }
    }
}
