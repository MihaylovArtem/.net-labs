using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab1.Logger;

namespace Tests {
    /// <summary>
    /// Класс тестов логгера
    /// </summary>
    [TestFixture]
    class LoggerTests {
        private ExceptionLogger exLogger;
        /// <summary>
        /// Начальная настройка
        /// </summary>
        [SetUp]
        public void init() {
            exLogger = new ExceptionLogger();
        }
        /// <summary>
        /// Тест логгирования исключения
        /// </summary>
        [Test]
        public void ExceptionLoggerTest() {
            Assert.DoesNotThrow(() => exLogger.LogException(new Exception()));
        }
    }
}
