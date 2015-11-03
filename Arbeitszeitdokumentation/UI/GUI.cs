using Arbeitszeitdokumentation.view;
using Arbeitszeitdokumentation.Controller;
using System.Windows.Forms;
namespace Arbeitszeitdokumentation.UI
{
    public class GUI
    {
        private IController fachkonzept;

        public GUI(IController fachkonzept)
        {
            Form azd = new AZD(fachkonzept);
            System.Console.WriteLine("Hello");
            Application.Run(azd);
            this.fachkonzept = fachkonzept;
        }
    }
}
