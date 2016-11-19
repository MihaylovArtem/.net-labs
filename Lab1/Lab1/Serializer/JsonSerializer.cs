using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;
using Lab1.Projects;
using Newtonsoft.Json;

namespace Lab1.Serializer {
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
