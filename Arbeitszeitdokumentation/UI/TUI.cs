using Arbeitszeitdokumentation.Controller;
namespace Arbeitszeitdokumentation.UI
{
    class TUI
    {
        private IController fachkonzept;

        public TUI(IController fachkonzept)
        {
            this.fachkonzept = fachkonzept;
        }
    }
}
