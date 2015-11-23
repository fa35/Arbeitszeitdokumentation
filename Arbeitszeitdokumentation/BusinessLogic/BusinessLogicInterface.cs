using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;

namespace Arbeitszeitdokumentation.BusinessLogic
{
    public interface IBusinessLogic
    {
        void CreateEmployee(Employee employee);

        List<Employee> GetEmployees();
    }
}
