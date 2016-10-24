using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Logger {
    enum LoggerType
    {
        console,
        file
    }
    /// <summary>
    /// Базовый класс логгера
    /// </summary>
    interface ILogger {
        /// <summary>
        /// Тип логгера (файл или консоль)
        /// </summary>
        LoggerType loggerType { get; }
        /// <summary>
        /// Путь к файлу, в который пишутся логи
        /// </summary>
        string logFilePath { get; }
    }
}
