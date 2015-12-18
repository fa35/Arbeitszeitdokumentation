using Arbeitszeitdokumentation.UI;
using Arbeitszeitdokumentation.BusinessLogic;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation
{
    class Program
    {
        static void Main(string[] args)
        {

            var app = new GUI(new SortedBusinessLogic(new Proxy(new FirebirdStorage())));
            // = new TUI(new SortedBusinessLogic(new Proxy(new MockStorage())));  //<-- sortiert
            // = new TUI(new Proxy(new MockStorage()));  //<-- nicht sortiert
        }
    }
}
