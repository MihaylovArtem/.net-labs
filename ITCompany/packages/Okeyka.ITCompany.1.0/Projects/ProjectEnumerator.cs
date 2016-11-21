using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;
using Lab1.Employees;

namespace Lab1.Projects {
    class ProjectEnumerator<T> : IEnumerator<T> where T : IEmployee<IComputer>
    {
        private readonly IProject<T> project;
        private int index;

        public T Current
        {
            get
            {
                return project.participants[index];
            }
        }

        object IEnumerator.Current {
            get {
                return Current;
            }
        }

        public ProjectEnumerator(IProject<T> project)
        {
            this.project = project;
            index = -1;
        }

        public bool MoveNext()
        {
            if (index + 1 >= project.Count)
            {
                    return false;
            }
            index++;
            return true;
        }

        public void Dispose()
        {
            
        }

        public void Reset()
        {
            index = -1;
        }

    }
}
