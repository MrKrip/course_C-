using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class ReNameStrategy:BasicHandler
    {
        public ReNameStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "8")
            {
                OurProg.SetStrategy(new ChangeName());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
