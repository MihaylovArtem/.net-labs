using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    public class Mac : ComputerBase
    {
        private const string ManufactureCompany = "Apple";
        private const string OS = "MacOS";

        public Mac(int purchaseYear, int cost) : base(purchaseYear, ManufactureCompany, cost, OS)
        {
            Console.WriteLine("Mac added!");
        }
    }
}
