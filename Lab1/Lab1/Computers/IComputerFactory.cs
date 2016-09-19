using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    /// <summary>
    /// Интерфейс абстрактной фабрики
    /// </summary>
    interface IComputerFactory
    {
        /// <summary>
        /// Купить новый компьютер
        /// </summary>
        /// <returns>Объект класса Computer</returns>
        Computer BuyNewComputer();
    }
}
