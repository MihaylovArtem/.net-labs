using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.Employees {

    public enum EventType {
        install,
        uninstall
    }
    /// <summary>
    /// Аргументы событий сотрудника
    /// </summary>
    public class EmployeeActionArgs {
        public EmployeeActionArgs(EventType type)
        {
            ActionType = type;
        }
        public EventType ActionType { get; private set; }
    }
    /// <summary>
    /// Аргументы события установки программы
    /// </summary>
    public class EmployeeInstallActionArgs : EmployeeActionArgs
    {
        public EmployeeInstallActionArgs(string progName) : base(EventType.install)
        {
            programName = progName;
        }

        /// <summary>
        /// Название программы
        /// </summary>
        public string programName { get; private set; }
    }
    /// <summary>
    /// Аргументы события удаления программы
    /// </summary>
    public class EmployeeUninstallActionArgs : EmployeeActionArgs {
        public EmployeeUninstallActionArgs(string progName) : base(EventType.uninstall) {
            programName = progName;
        }
        /// <summary>
        /// Название программы
        /// </summary>
        public string programName { get; private set; }
    }
}
