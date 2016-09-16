using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    public class ComputerBase : IntComputer {
        public int purchaseYear { get; private set; }
        public string manufactureCompany { get; private set; }
        public int cost { get; private set; }
        public string operationSystem { get; private set; }

        protected ComputerBase(int PurchaseYear, string ManufactureCompany, int Cost, string OperationSystem)
        {
            purchaseYear = PurchaseYear;
            manufactureCompany = ManufactureCompany;
            cost = Cost;
            operationSystem = OperationSystem;
        }
    }
}

