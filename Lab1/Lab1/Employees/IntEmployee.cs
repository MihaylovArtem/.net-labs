using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Employees
{
    public interface IntEmployee {
        //salary - зарплата
        //name - имя сотрудника
        //position - должность сотрудника
        int salary { get; }
        string name { get; }
        string position { get; }
        string project { get; }
    }
}
