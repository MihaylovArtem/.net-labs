using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.Logger {
    class LoggerEventArgs {
        public string Message { get; private set; }

        public LoggerEventArgs(string message)
        {
            Message = message;
        }
    }
}
