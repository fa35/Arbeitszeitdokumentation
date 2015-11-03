using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.Controller
{
    public class SortedController : AbstractControllerDecorator
    {

        public SortedController(IStorage storage) : base(storage) { }

        public SortedController(IController controller) : base(controller) { }
        
        public override List<Employee> GetEmployees()
        {
            var result = Controller.GetEmployees();
            result.Sort(CompareEmployeeByLastName);
            return result;
        }

        protected int CompareEmployeeByLastName(Employee employee1, Employee employee2)
        {
            return String.Compare(employee1.LastName, employee2.LastName, StringComparison.CurrentCulture);
        }
    }
}
