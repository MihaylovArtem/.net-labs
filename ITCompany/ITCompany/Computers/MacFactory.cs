using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.Computers {
    public class MacFactory : IComputerFactory {
        /// <summary>
        /// Переопределение метода абстрактной фабрики
        /// </summary>
        /// <returns></returns>
        public Computer BuyNewComputer()
        {
            return new Mac(2016, 51000);
        }
    }
}
