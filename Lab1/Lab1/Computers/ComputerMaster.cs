using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Computers {
    public class ComputerMaster<T> : IComputerMaster<T> where T : IComputer
    {
        /// <summary>
        /// Ремонт компьютера
        /// </summary>
        /// <param name="computer"></param>
        public void repair(T computer) {
            Console.WriteLine("Repaired!");
        } 
    }
}
