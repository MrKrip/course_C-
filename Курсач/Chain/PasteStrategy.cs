using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class PasteStrategy:BasicHandler
    {
        public PasteStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "7")
            {
                OurProg.SetStrategy(new Paste());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
