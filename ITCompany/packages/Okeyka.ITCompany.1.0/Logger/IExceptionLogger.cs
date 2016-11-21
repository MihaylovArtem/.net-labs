using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Logger {
    /// <summary>
    /// класс для логирования системных и пользовательских исключений
    /// </summary>
    interface IExceptionLogger {
        /// <summary>
        /// Логгирование исключений
        /// </summary>
        /// <param name="ex">Логгируемое исключение</param>
        void LogException(Exception ex);
    }
}
