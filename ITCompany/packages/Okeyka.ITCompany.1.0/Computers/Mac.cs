using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    /// <summary>
    /// Класс-потомок от абстрактного класса Computer
    /// </summary>
    [Serializable]
    public class Mac : Computer
    {
        private const string ManufactureCompany = "Apple";
        private const string Os = "MacOS";
        /// <summary>
        /// Конструктор класса Mac
        /// </summary>
        /// <param name="purchaseYear"></param>
        /// <param name="cost"></param>
        public Mac(int purchaseYear, int cost) : base(purchaseYear, ManufactureCompany, cost, Os)
        {
            //Console.WriteLine("Mac added!");
        }

        public Mac() : base(2010, "Apple", 30000, "MacOS")
        {
            
        }

        public override void installAntivirus()
        {
            Console.WriteLine("Antivirus downloaded from AppStore");
        }

        public override object Clone()
        {
            return new Mac(purchaseYear, cost);
        }
    }
}
