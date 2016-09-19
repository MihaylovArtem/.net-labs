﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Computers;

namespace Lab1.Employees
{
    /// <summary>
    /// Интерфейс класса Employee
    /// </summary>
    public interface IEmployee {
        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        int salary { get; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        string name { get; }
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        string position { get; }
        /// <summary>
        /// Проект, в котором участвует сотрудник
        /// </summary>
        string project { get; }
        /// <summary>
        /// Компьютер, который закреплен за этим сотрудником
        /// </summary>
        IComputer computer { get; }
    }
}