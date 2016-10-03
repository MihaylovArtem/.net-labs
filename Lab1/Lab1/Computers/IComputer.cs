using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    /// <summary>
    /// Интерфейс класса Computer
    /// </summary>
    public interface IComputer : ICloneable {
        /// <summary>
        /// Год покупки
        /// </summary>
        int purchaseYear { get; }
        /// <summary>
        /// Компания-производитель
        /// </summary>
        string manufactureCompany { get; }
        /// <summary>
        /// Стоимость
        /// </summary>
        int cost { get; }
        /// <summary>
        /// Операционная система
        /// </summary>
        string operationSystem { get; }

        void installAntivirus();
    }
}
