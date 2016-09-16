using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    interface IntComputer {
        int purchaseYear { get; }
        string manufactureCompany { get; }
        int cost { get; }
        string operationSystem { get; }
    }
}
