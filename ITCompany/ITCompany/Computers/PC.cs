using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Logger;

namespace ITCompany.Computers {
    /// <summary>
    /// Класс PC
    /// </summary>
   [Serializable]
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

        public PC() : base(2010, "IBM", 30000, "Windows")
        {
            
        }

        public override void installAntivirus()
        {
            Console.WriteLine("Antivirus was successfully installed from bestantirus2016forfree.com");
        }

        public override object Clone()
        {
            return new PC(purchaseYear, manufactureCompany, cost);
        }
    }
}
