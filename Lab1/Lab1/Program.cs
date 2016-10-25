using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

            var exLogger = new ExceptionLogger("E:\\log.txt");

            try
            {
                var configFilePath = Path.GetFullPath("config.txt");
                var newReader = new StreamReader(configFilePath);
                var st = newReader.ReadLine();
                var objectsCount = Int32.Parse(st);
                Console.WriteLine("{0}",objectsCount);
                newReader.Close();
            }
            catch (Exception ex)
            {   
                exLogger.LogException(ex);
            }
            
            Console.WriteLine();

            Employee<Mac> newEmployee = new Manager<Mac>("Nikolay", new Mac(2015, 50000));
            var newLogger = new EventLogger<Employee<Mac>>(newEmployee, "E:\\log.txt");
            var newLogger2 = new EventLogger<Employee<Mac>>(newEmployee);
            
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
                newEmployee.installProgram("");
            }
            catch (Exception ex)
            {
                exLogger.LogException(ex);
            }

            Console.ReadLine();
        }


    }
}
