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
            return Controller.GetWorkers();
        }
    }
}
