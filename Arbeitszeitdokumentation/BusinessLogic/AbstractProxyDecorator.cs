using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.BusinessLogic
{
    public abstract class AbstractProxyDecorator : IBusinessLogic
    {
        protected IBusinessLogic BusinessLogic;


        public AbstractProxyDecorator(IStorage storage)
        {
            BusinessLogic = new BusinessLogic.Proxy(storage);
        }

        public AbstractProxyDecorator(IBusinessLogic businessLogic)
        {
            BusinessLogic = businessLogic;
        }
        
        public void CreateEmployee(Employee employee)
        {
            BusinessLogic.CreateEmployee(employee);
        }

        public virtual List<Employee> GetEmployees()
        {
            return BusinessLogic.GetEmployees();
        }
    }
}
