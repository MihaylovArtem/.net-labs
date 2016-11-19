using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;
using Lab1.Projects;
using Lab1.Serializer;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Класс тестов сериализаторов
    /// </summary>
    [TestFixture]
    public class SerialiersTests
    {
        private Project<Manager<Mac>> testProject;

        private const string pathXml = "project.xml";
        private const string pathBin = "project.bin";
        private const string pathJson = "project.json";

        /// <summary>
        /// Первоначальная настройка
        /// </summary>
        [SetUp]
        public void setup()
        {
            var partList = new List<Manager<Mac>>
            {
                new Manager<Mac>("Алексей", new Mac(2015, 50000)),
                new Manager<Mac>("Андрей", new Mac(2014, 30000)),
                new Manager<Mac>("Николай", new Mac(2014, 45000))
            };
            testProject = new Project<Manager<Mac>>("Test Project", partList);
        }
        /// <summary>
        /// XML test
        /// </summary>
        [Test]
        public void xmlTest()
        {
            var xmlSer = new XmlSerializer<Manager<Mac>>();
            xmlSer.serialize(testProject, pathXml);

            var project2 = xmlSer.deserialize(pathXml);
            CollectionAssert.AreEqual(testProject.ToString(), project2.ToString());
        }
        /// <summary>
        /// JSON test
        /// </summary>
        [Test]
        public void jsonTest() {
            var jsonSer = new JsonSerializer<Manager<Mac>>();
            jsonSer.serialize(testProject, pathJson);

            var project2 = jsonSer.deserialize(pathJson);
            CollectionAssert.AreEqual(testProject.ToString(), project2.ToString());
        }
        /// <summary>
        /// Bin test
        /// </summary>
        [Test]
        public void binTest() {
            var binSer = new BinarySerializer<Manager<Mac>>();
            binSer.serialize(testProject, pathBin);

            var project2 = binSer.deserialize(pathBin);
            CollectionAssert.AreEqual(testProject.ToString(), project2.ToString());
        }

    }
}
