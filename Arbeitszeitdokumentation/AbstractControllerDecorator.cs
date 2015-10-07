using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeitdokumentation
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
        
        public void CreateWorker(Worker worker)
        {
            Controller.CreateWorker(worker);
        }

        public virtual List<Worker> GetWorkers()
        {
            return Controller.GetWorkers();
        }
    }
}
