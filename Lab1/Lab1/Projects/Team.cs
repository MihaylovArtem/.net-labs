using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;

namespace Lab1.Projects {
    class Team<T> : IEnumerable<T> where T : IEmployee<IComputer>
    {
        private readonly List<T> team;

        public Team(T[] employeeArray)
        {
            team = new List<T>(employeeArray.Count());
            for (int i = 0; i < employeeArray.Length; i++)
            {
                team[i] = employeeArray[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ProjectEnumerator<T>(new Project<T>("", team));
        }

        private IEnumerator getEnumerator1()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return getEnumerator1();
        }
    }
}
