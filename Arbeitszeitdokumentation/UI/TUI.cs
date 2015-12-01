using Arbeitszeitdokumentation.BusinessLogic;
using Arbeitszeitdokumentation.Container;
using System;

namespace Arbeitszeitdokumentation.UI
{
    public class TUI
    {
        private IBusinessLogic fachkonzept;

        public TUI(IBusinessLogic fachkonzept)
        {
            this.fachkonzept = fachkonzept;
            Hauptmenue intro = new Hauptmenue(fachkonzept);
            intro.Intro();
            //Console.ReadLine();
        }

    }
}
