using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab1.Employees;
using Lab1.Computers;
using Lab1.Logger;

namespace Tests {
    /// <summary>
    /// Класс тестов для класса Employee и связанных с ним классов
    /// </summary>
    [TestFixture]
    class EmployeeTests {
        private Developer<PC> testDev;
        String noFile = "E:\\nolog.txt";
        /// <summary>
        /// Начальная настройка
        /// </summary>
        [SetUp]
        public void init() {
            testDev = new Developer<PC>("Andrey", new PC(2014, "Microsoft", 10000));
            var logger = new EventLogger<Developer<PC>>(testDev, null);
            var file = "E:\\log.txt";
            var loggerFile = new EventLogger<Developer<PC>>(testDev, file);
        }
        /// <summary>
        /// Тест конструктора без параметров класса Developer
        /// </summary>
        [Test]
        public void developerEmptyTest() {
            var test = new Developer<PC>();
            Assert.AreEqual(test.name, "Noname");
        }
        /// <summary>
        /// Тест создания логгера событий
        /// </summary>
        [Test]
        public void log() {
            Assert.DoesNotThrow(() => new EventLogger<Developer<PC>>(testDev, noFile));
        }
        /// <summary>
        /// Тест методов, содержащих логгирование
        /// </summary>
        [Test]
        public void installTest() {
            Assert.Throws<UserException>(() => testDev.installProgram(null));
            Assert.DoesNotThrow(() => testDev.installProgram("test program"));
        }
        [Test]
        public void uninstallTest() {
            Assert.DoesNotThrow(() => testDev.uninstallProgram("test program"));
            Assert.Throws<UserException>(() => testDev.uninstallProgram(null));
        }
        /// <summary>
        /// Тест метода, принимающего на вход Action
        /// </summary>
        [Test]
        public void actionTest() {
            var mac = new Mac();
            Assert.DoesNotThrow(() => testDev.performActionWithComputer(() => mac.installAntivirus()));
        }
    }
}
