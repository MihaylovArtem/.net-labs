using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;
using Lab1.Logger;
using Lab1.Projects;
using Lab1.Serializer;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            var part = new List<Manager<Mac>>();
            for (int i = 0; i < 100000; i++)
            {
                var employee = new Manager<Mac>(i.ToString(), new Mac(2015, 10000));
                part.Add(employee);
            }



            var proj = new Project<Manager<Mac>>("Test", part);
            
            Console.WriteLine("Project added");
            
            //proj.asyncSortWithProg(new Progress<int>(Console.WriteLine));

            Console.ReadLine();

            var partList = new List<Manager<Mac>>();

            for (var i = 0; i < 10; i++) {
                var newEmployee = new Manager<Mac>("Алексей", new Mac(2015, (i + 1) * 1000));
                partList.Add(newEmployee);
            }
            var project = new Project<Manager<Mac>>("Test Project", partList);

            //Bin serializer
            //var bin = new BinarySerializer<Manager<Mac>>();
            //bin.serialize(project, @"E:\test.dat");
            //var project2 = bin.deserialize(@"E:\test.dat");
            //Console.WriteLine("\n\n\n{0}\n", project.name);
            //for (var i = 0; i < project2.participants.Count; i++)
            //{
            //    Console.WriteLine("{0} {1}", project2.participants[i].name, project2.participants[i].computer.cost);              
            //}
            //Console.ReadLine();

            //Json serializer
            var json = new JsonSerializer<Manager<Mac>>();
            json.serialize(project, @"E:\test.json");
            var project2 = json.deserialize(@"E:\test.json");
            Console.WriteLine("\n\n\n{0}\n", project.name);
            for (var i = 0; i < project2.participants.Count; i++) {
                Console.WriteLine("{0} {1}", project2.participants[i].name, project2.participants[i].computer.cost);
            }
            Console.ReadLine();

            //Xml serializer
            //var xml = new XmlSerializer<Manager<Mac>>();
            //xml.serialize(project, @"E:\test.xml");
            //var project2 = xml.deserialize(@"E:\test.xml");
            //Console.WriteLine("\n\n\n{0}\n", project.name);
            //for (var i = 0; i < project2.participants.Count; i++) {
            //    Console.WriteLine("{0} {1}", project2.participants[i].name, project2.participants[i].computer.cost);
            //}
            //Console.ReadLine();
        }
    }
}
