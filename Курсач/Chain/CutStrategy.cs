using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class CutStrategy:BasicHandler
    {
        public CutStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "6")
            {
                OurProg.SetStrategy(new Cut());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
