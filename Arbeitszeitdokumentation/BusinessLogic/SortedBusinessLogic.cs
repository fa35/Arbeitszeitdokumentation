using System;
using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.BusinessLogic
{
    public class SortedBusinessLogic : AbstractBusinessLogicDecorator
    {

        public SortedBusinessLogic(IStorage storage) : base(storage) { }

        public SortedBusinessLogic(IBusinessLogic businessLogic) : base(businessLogic) { }
        
        public override List<Employee> GetEmployees()
        {
            var result = BusinessLogic.GetEmployees();
            result.Sort(CompareEmployeeByLastName);
            return result;
        }

        protected int CompareEmployeeByLastName(Employee employee1, Employee employee2)
        {
            return String.Compare(employee1.LastName, employee2.LastName, StringComparison.CurrentCulture);
        }
    }
}
