using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    /// <summary>
    /// Класс PC
    /// </summary>
    public class PC : Computer
    {
        private const string Os = "Windows";
        /// <summary>
        /// Конструктор класса PC
        /// </summary>
        /// <param name="purchaseYear"></param>
        /// <param name="manufactureCompany"></param>
        /// <param name="cost"></param>
        public PC(int purchaseYear, string manufactureCompany, int cost)
            : base(purchaseYear, manufactureCompany, cost, Os)
        {
            Console.WriteLine("PC Added!");
        }
    }
}
