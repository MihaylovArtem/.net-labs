using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.Computers {
    interface IComputerMaster<in T> where T : IComputer
    {
        /// <summary>
        /// Ремонт компьютера
        /// </summary>
        /// <param name="computer"></param>
        void repair(T computer);
    }
}
