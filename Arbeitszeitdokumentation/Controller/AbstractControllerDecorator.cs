using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation.Controller
{
    public abstract class AbstractControllerDecorator : IController
    {
        protected IController Controller;


        public AbstractControllerDecorator(IStorage storage)
        {
            Controller = new Controller(storage);
        }

        public AbstractControllerDecorator(IController controller)
        {
            Controller = controller;
        }
        
        public void CreateEmployee(Employee employee)
        {
            Controller.CreateEmployee(employee);
        }

        public virtual List<Employee> GetEmployees()
        {
            return Controller.GetEmployees();
        }
    }
}
