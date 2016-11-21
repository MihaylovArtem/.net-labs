using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ITCompany.Employees;
using ITCompany.Computers;
using ITCompany.Projects;

namespace Tests {
    /// <summary>
    /// Класс тестов для класса-коллекции и связанных с ним методов
    /// </summary>
    [TestFixture]
    class CollectionTests {
        
        private const string testName = "test name";
        private List<Manager<Mac>> testList;
        private Project<Manager<Mac>> project;
        /// <summary>
        /// Начальная настройка тестов коллекции
        /// </summary>
        [SetUp]
        public void Init() {
            testList = new List<Manager<Mac>> {
                new Manager<Mac>("Alexey", new Mac(2015, 50000)),
                new Manager<Mac>("Nikolay", new Mac(2016, 45000)),
                new Manager<Mac>("Andrey", new Mac(2013, 55000))
            };
        } 
        /// <summary>
        /// Тест конструктура класса коллекции
        /// </summary>
        [Test]
        public void CreateTest() {
            project = new Project<Manager<Mac>>(testName, testList);
            Assert.AreEqual(project.name, testName);
            Assert.AreEqual(project.participants.Count(), testList.Count());

            var project2 = new Project<Manager<Mac>>(testName);
            Assert.AreEqual(project2.name, testName);
        }
        /// <summary>
        /// Тест переопределенных методов коллекции
        /// </summary>
        [Test]
        public void CollectionMethodsTest() {
            project = new Project<Manager<Mac>>(testName, testList);
            Assert.DoesNotThrow(() => project.printProjectTeam());

            Assert.AreEqual(project.IsReadOnly, false);

            var testManager = new Manager<Mac>("Alexey", new Mac(2015, 50000));
            project.Add(testManager);
            Assert.AreEqual(4, project.Count());
            Assert.IsTrue(project.Contains(testManager));

            project.Remove(testManager);
            Assert.AreEqual(3, project.Count());

            Assert.NotNull(project.GetEnumerator());
          
            project.Clear();
            Assert.AreEqual(0, project.Count());
        }
        /// <summary>
        /// Тест асинхронной сортировки
        /// </summary>
        [Test]
        public void sortAsyncTest() {
            project = new Project<Manager<Mac>>(testName, testList);
            int raiseCount = 0;
            Task task = project.asyncSortWithProg(new Progress<int>(i => raiseCount++));
            task.Wait();
            Assert.AreEqual(project.participants[0].name, "Nikolay");
        }
        /// <summary>
        /// Тест синхронной сортировки
        /// </summary>
        [Test]
        public void sortTest() {
            project = new Project<Manager<Mac>>(testName, testList);
            project.sortTeam("name");
            Assert.AreEqual(project.participants[0].name, "Alexey");
        }
    }
}
