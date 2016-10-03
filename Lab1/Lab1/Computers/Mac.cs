using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    /// <summary>
    /// Класс-потомок от абстрактного класса Computer
    /// </summary>
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
            Console.WriteLine("Mac added!");
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
