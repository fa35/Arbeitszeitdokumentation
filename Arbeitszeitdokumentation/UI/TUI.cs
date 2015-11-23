using Arbeitszeitdokumentation.BusinessLogic;

namespace Arbeitszeitdokumentation.UI
{
    class TUI
    {
        private IBusinessLogic fachkonzept;

        public TUI(IBusinessLogic fachkonzept)
        {
            this.fachkonzept = fachkonzept;
        }
    }
}
