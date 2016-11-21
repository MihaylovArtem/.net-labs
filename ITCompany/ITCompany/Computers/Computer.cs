using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany.Logger;

namespace ITCompany.Computers {
    /// <summary>
    /// Абстрактный класс Computer с интерфейсом ComputerInt
    /// </summary>
    [Serializable]
    public abstract class Computer : IComputer {
        /// <summary>
        /// Год покупки
        /// </summary>
        public int purchaseYear { get; set; }
        /// <summary>
        /// Компания-производитель
        /// </summary>
        public string manufactureCompany { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public int cost { get; set; }
        /// <summary>
        /// Операционная система
        /// </summary>
        public string operationSystem { get; set; }
        /// <summary>
        /// Конструктор класса Computer
        /// </summary>
        /// <param name="PurchaseYear"></param>
        /// <param name="ManufactureCompany"></param>
        /// <param name="Cost"></param>
        /// <param name="OperationSystem"></param>
        protected Computer(int PurchaseYear, string ManufactureCompany, int Cost, string OperationSystem)
        {
            if (Cost < 0)
            {
                throw new UserException("Cost can't be below 0");
            }
            purchaseYear = PurchaseYear;
            manufactureCompany = ManufactureCompany;
            cost = Cost;
            operationSystem = OperationSystem;
        }

        public abstract void installAntivirus();

        public abstract object Clone();
    }
}

