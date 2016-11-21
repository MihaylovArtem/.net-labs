using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.Logger {

    abstract public class Logger : ILogger {
        public string logFilePath { get; private set; }
        public LoggerType loggerType { get; private set; }

        protected Logger(string filePath)
        {
            if (filePath == null)
            {
                loggerType = LoggerType.console;
                return;
            }
            logFilePath = filePath;
            loggerType = LoggerType.file;
            if (File.Exists(filePath))
            {
                return;
            }
            var file = File.Create(filePath);
            file.Close();
        }
        /// <summary>
        /// Получение TextWriter'a в зависимости от типа логгирования
        /// </summary>
        /// <returns></returns>
        protected TextWriter GetWriter() {
            return loggerType == LoggerType.console ? Console.Out : File.AppendText(logFilePath);
        }
    }
}
