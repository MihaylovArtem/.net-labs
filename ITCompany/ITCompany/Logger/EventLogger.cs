using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ITCompany.Computers;
using ITCompany.Employees;

namespace ITCompany.Logger {
    public class EventLogger<T> : Logger, IEventLogger<T> where T : IEmployee<IComputer>
    {
        private readonly T employee;
        private readonly object locker = new object();
        public EventLogger(T Employee, string filePath = null) : base(filePath)
        {
            employee = Employee;

            employee.OnInstallProgram += Employee_eventHandler;
            employee.OnUninstallProgram += Employee_eventHandler;
            
        }

        public EventLogger (string filePath = null) : base(filePath) {

        }
        /// <summary>
        /// Логгирование события пользователя
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="emp"></param>
        /// <param name="args"></param>
        private void LogEmployeeEvent(TextWriter writer, T emp, EmployeeActionArgs args)
        {
             writer.WriteLine("Employee:{0}, Action:{1}", emp.name, args.ActionType);
             writer.WriteLine();
        }
        /// <summary>
        /// Логгирует сообщение
        /// </summary>
        /// <param name="Message"></param>
        public void Log(string Message) {
            var writer = GetWriter();
            writer.WriteLine("{0}", DateTime.Now.ToString("HH:mm:ss.fff"));
            writer.WriteLine("{0}", Message);
            writer.WriteLine();
            writer.Close();
        }

        private void Employee_eventHandler(EmployeeActionArgs args)
        {
            var threadStart = new ThreadStart(() =>
            {
                lock (locker)
                {
                    var writer = GetWriter();
                    LogEmployeeEvent(writer, employee, args);
                    writer.Close();
                }
            });
            var thread = new Thread(threadStart)
            {
                IsBackground = true
            };
            thread.Start();

        }
    }
}
