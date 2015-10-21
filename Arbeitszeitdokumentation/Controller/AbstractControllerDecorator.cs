using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arbeitszeitdokumentation.Container;

namespace Arbeitszeitdokumentation.Controller
{
    abstract class AbstractControllerDecorator : IController
    {
        protected IController Controller;


        public AbstractControllerDecorator()
        {
            Controller = new Controller();
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
