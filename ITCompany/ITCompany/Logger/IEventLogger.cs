using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Computers;
using ITCompany.Employees;

namespace ITCompany.Logger {
    interface IEventLogger<out T> where T:IEmployee<IComputer>
    {
        void Log(string Message);
    }
}
