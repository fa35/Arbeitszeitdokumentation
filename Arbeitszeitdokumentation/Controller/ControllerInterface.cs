using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arbeitszeitdokumentation.Container;

namespace Arbeitszeitdokumentation.Controller
{
    interface IController
    {
        void CreateEmployee(Employee employee);

        List<Employee> GetEmployees();
    }
}
