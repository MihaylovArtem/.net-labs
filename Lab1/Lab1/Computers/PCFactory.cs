using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    public class PCFactory : IComputerFactory {
        /// <summary>
        /// Переопределение метода абстрактной фабрики
        /// </summary>
        /// <returns></returns>
        public Computer BuyNewComputer()
        {
            return new PC(2016,"Lenovo",20000);
        }
    }
}
