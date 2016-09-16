using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Employees {
    public abstract class EmployeeBase : IntEmployee {

        public string project
        {
            get { return projectName; }
            set {
                if (value != null) {
                    projectName = value;
                }
            }
        }
        public int salary { get; private set; }
        public string name { get; private set; }
        public string position { get; private set; }
        private string projectName;
        protected EmployeeBase(string Name, string Position, int Salary, string Project) {
            name = Name;
            position = Position;
            salary = Salary;
            project = Project;
        }
    }
}
