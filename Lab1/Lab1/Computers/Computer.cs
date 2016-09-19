using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    /// <summary>
    /// Абстрактный класс Computer с интерфейсом ComputerInt
    /// </summary>
    public abstract class Computer : IComputer {
        /// <summary>
        /// Год покупки
        /// </summary>
        public int purchaseYear { get; private set; }
        /// <summary>
        /// Компания-производитель
        /// </summary>
        public string manufactureCompany { get; private set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public int cost { get; private set; }
        /// <summary>
        /// Операционная система
        /// </summary>
        public string operationSystem { get; private set; }
        /// <summary>
        /// Конструктор класса Computer
        /// </summary>
        /// <param name="PurchaseYear"></param>
        /// <param name="ManufactureCompany"></param>
        /// <param name="Cost"></param>
        /// <param name="OperationSystem"></param>
        protected Computer(int PurchaseYear, string ManufactureCompany, int Cost, string OperationSystem)
        {
            purchaseYear = PurchaseYear;
            manufactureCompany = ManufactureCompany;
            cost = Cost;
            operationSystem = OperationSystem;
        }
    }
}

