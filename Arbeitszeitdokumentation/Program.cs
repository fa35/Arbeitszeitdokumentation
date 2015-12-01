using Arbeitszeitdokumentation.UI;
using Arbeitszeitdokumentation.BusinessLogic;
using Arbeitszeitdokumentation.Storage;

namespace Arbeitszeitdokumentation
{
    class Program
    {
        static void Main(string[] args)
        {

            var app = new TUI(new SortedProxy(new MockStorage()));

        }
    }
}
