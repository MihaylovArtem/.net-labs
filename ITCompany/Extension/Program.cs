using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Employees;
using ITCompany.Projects;
using ITCompany.Computers;
using ITCompany.Logger;

namespace Extension {
    class Program {
        static void Main(string[] args) {
            var team = new List<Developer<Mac>> {
                new Developer<Mac>("Andrey", new Mac(2013, 50000)),
                new Developer<Mac>("Innokentiy", new Mac(2011, 12000))
            };

            var logger = new EventLogger<IEmployee<IComputer>>("E:\\testLog.txt");

            var proj = new Project<Developer<Mac>>("test", team);
            Console.WriteLine(proj.ConvertToString(logger));
            Console.WriteLine();

            Console.WriteLine(proj.FindEmployeesWithLongName(logger).Count);
            Console.WriteLine();

            Console.WriteLine(proj.FindEmployeesWithOldMacs(logger).Count);

            Console.ReadLine();
        }
    }
}
