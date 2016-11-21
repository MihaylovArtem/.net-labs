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

        public Team(List<T> employeeArray)
        {
            team = new List<T>(employeeArray.Count());
            for (var i = 0; i < employeeArray.Count; i++)
            {
                team[i] = employeeArray[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ProjectEnumerator<T>(new Project<T>("", team));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ProjectEnumerator<T>(new Project<T>("", team));
        }
    }
}
