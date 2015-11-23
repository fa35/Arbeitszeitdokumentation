using Arbeitszeitdokumentation.view;
using Arbeitszeitdokumentation.BusinessLogic;
using System.Windows.Forms;

namespace Arbeitszeitdokumentation.UI
{
    public class GUI
    {
        private IBusinessLogic fachkonzept;

        public GUI(IBusinessLogic fachkonzept)
        {
            Form azd = new AZD(fachkonzept);
            //System.Console.WriteLine("Hello");
            Application.Run(azd);
            this.fachkonzept = fachkonzept;
        }
    }
}
