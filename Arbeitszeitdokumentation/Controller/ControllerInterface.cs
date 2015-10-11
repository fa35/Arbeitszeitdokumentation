using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeitdokumentation.Controller
{
    interface IController
    {
        void CreateWorker(Worker worker);

        List<Worker> GetWorkers();
    }
}
