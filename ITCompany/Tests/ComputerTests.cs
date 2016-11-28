using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Computers;
using NUnit.Framework;
using ITCompany.Logger;

namespace Tests {
    /// <summary>
    /// Класс тестов для класса Computer и связанными с ним методами
    /// </summary>
    [TestFixture]
    class ComputerTests {

        private Mac testMac;
        private Mac testMac2;
        private PC testPC;
        private PC testPC2;
        private string macSystem = "MacOS";
        private string macManufactureCompany = "Apple";
        private string pcSystem = "Windows";
        private int baseCost = 30000;
        private int baseYear = 2010;
        private string baseCompany = "IBM";

        /// <summary>
        /// Начальная настройка тестов класса Computer
        /// </summary>
        [SetUp]
        public void Init() {
            testMac = new Mac(baseYear, baseCost);
            testMac2 = new Mac();
            testPC = new PC(baseYear, baseCompany, baseCost);
            testPC2 = new PC();
        }
        /// <summary>
        /// Тест конструктора с параметрами класса Mac
        /// </summary>
        [Test]
        public void parametersMac() {
            Assert.AreEqual(testMac.purchaseYear, baseYear);
            Assert.AreEqual(testMac.cost, baseCost);
            Assert.AreEqual(testMac.manufactureCompany, macManufactureCompany);
            Assert.AreEqual(testMac.operationSystem, macSystem);
        }
        /// <summary>
        /// Тест конструктора без параметров класса Мас
        /// </summary>
        [Test]
        public void withoutParametresMac() {
            Assert.AreEqual(testMac2.purchaseYear, baseYear);
            Assert.AreEqual(testMac2.cost, baseCost);
            Assert.AreEqual(testMac2.manufactureCompany, macManufactureCompany);
            Assert.AreEqual(testMac2.operationSystem, macSystem);
        }
        /// <summary>
        /// Тест конструктора с параметрами класса РС
        /// </summary>
        [Test]
        public void parametersPC() {
            Assert.AreEqual(testPC.purchaseYear, baseYear);
            Assert.AreEqual(testPC.cost, baseCost);
            Assert.AreEqual(testPC.manufactureCompany, baseCompany);
            Assert.AreEqual(testPC.operationSystem, pcSystem);
        }
        /// <summary>
        /// Тест конструктора без параметров класса РС
        /// </summary>
        [Test]
        public void withoutParametresPC() {
            Assert.AreEqual(testPC2.purchaseYear, baseYear);
            Assert.AreEqual(testPC2.cost, baseCost);
            Assert.AreEqual(testPC2.manufactureCompany, baseCompany);
            Assert.AreEqual(testPC2.operationSystem, pcSystem);
        }
        /// <summary>
        /// Тест метода installAntivirus класса Computer
        /// </summary>
        [Test]
        public void installAV() {
            Assert.DoesNotThrow(() => testMac.installAntivirus());
            Assert.DoesNotThrow(() => testPC.installAntivirus());
        }
        /// <summary>
        /// Тестирование пользовательского исключения в конструкторе
        /// </summary>
        [Test]
        public void costBelowZeroTest() {
            Assert.Throws<UserException>(() => new Mac(2014, -11000));
        }
        /// <summary>
        /// Тест Сlonable 
        /// </summary>
        [Test]
        public void testClone() {
            var mac = testMac.Clone();
            var pc = testPC.Clone();
            Assert.AreEqual(mac.ToString(), testMac.ToString());
            Assert.AreEqual(pc.ToString(), testPC.ToString());
        }
        /// <summary>
        /// Тест методов класса ComputerMaster
        /// </summary>
        [Test]
        public void masterTest() {
            var master = new ComputerMaster<Mac>();
            Assert.DoesNotThrow(() => master.repair(new Mac()));
        }
    }
}
