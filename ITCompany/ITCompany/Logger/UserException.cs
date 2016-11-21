using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.Logger {
    /// <summary>
    /// Пользовательское исключение
    /// </summary>
    public class UserException : Exception {
        public UserException(string message) : base(message) {

        }
    }
}
