using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeitdokumentation
{
    class SortedController : AbstractControllerDecorator
    {
        public SortedController(IController controller) : base(controller) { }

        public override List<Worker> GetWorkers()
        {
            var result = Controller.GetWorkers();
            result.Sort(CompareWorkerByLastName);
            return result;
        }

        protected int CompareWorkerByLastName(Worker worker1, Worker worker2)
        {
            return String.Compare(worker1.LastName, worker2.LastName, StringComparison.CurrentCulture);
        }
    }
}
