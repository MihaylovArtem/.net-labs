using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;
using Lab1.Logger;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<Mac> newEmployee = new Manager<Mac>("Nikolay", new Mac(2015, 50000));
            var newLogger = new EventLogger<Employee<Mac>>(newEmployee, "E:\\log.txt");
            var exLogger = new ExceptionLogger("E:\\log.txt");
            newEmployee.installProgram("Xcode");
            Console.ReadLine();
            try
            {
                var totalPCs = 0;
                var PC1 = new PC(2014, "Lenovo", 45000);
                var middleCost = PC1.cost/totalPCs;
            }
            catch (Exception ex)
            {
                exLogger.LogException(ex);
            }
            try
            {
                newEmployee.installProgram(null);
            }
            catch (Exception ex)
            {
                exLogger.LogException(ex);
            }

            Console.ReadLine();
        }


    }
}
