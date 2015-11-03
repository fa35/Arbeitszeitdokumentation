using Arbeitszeitdokumentation.UI;
using Arbeitszeitdokumentation.Controller;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation
{
    class Program
    {
        static void Main(string[] args)
        {

            var app = new GUI(new SortedController(new MockStorage()));

        }
    }
}
