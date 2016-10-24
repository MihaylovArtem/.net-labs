using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1.Logger
{
    internal class ExceptionLogger : Logger, IExceptionLogger
    {

        public ExceptionLogger(string path = null) : base(path)
        {

        }
        public void LogException(Exception ex)
        {
            var writer = GetWriter();
            if (ex is UserException)
            {
                writer.WriteLine("User exception;\nTime: {0};\nType: {1};\nMessage: {2}\n",
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    ex.GetType(), ex.Message);
            }
            else
            {
                writer.WriteLine("System exception;\nTime: {0};\nType: {1};\nMessage: {2}\n",
                    DateTime.Now.ToString("HH:mm:ss.fff"),
                    ex.GetType(), ex.Message);
            }
            writer.WriteLine();
            writer.Close();
        }
    }
}
