using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ITCompany.Computers;

namespace Tests {
    /// <summary>
    /// Класс тестов класса-фабрики
    /// </summary>
    [TestFixture]
    class FactoryTests {
        /// <summary>
        /// Тест фабрики MacFactory
        /// </summary>
        [Test]
        public void MacFactoryTests() {
            var factory = new MacFactory();
            var mac = factory.BuyNewComputer();
            Assert.NotNull(mac);
        }
        /// <summary>
        /// Тест фабрики PCFactory
        /// </summary>
        [Test]
        public void PCFactoryTests() {
            var factory = new PCFactory();
            var pc = factory.BuyNewComputer();
            Assert.NotNull(pc);
        }
    }
}
