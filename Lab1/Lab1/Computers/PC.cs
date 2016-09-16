using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    public class PC : ComputerBase
    {
        public PC(int purchaseYear, string manufactureCompany, int cost, string operationSystem)
            : base(purchaseYear, manufactureCompany, cost, operationSystem)
        {
            Console.WriteLine("PC Added!");
        }
    }
}
