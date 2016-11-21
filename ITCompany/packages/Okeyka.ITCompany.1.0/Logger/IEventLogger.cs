using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;

namespace Lab1.Logger {
    interface IEventLogger<out T> where T:IEmployee<IComputer>
    {

    }
}
