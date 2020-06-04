using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class ParentStrategy:BasicHandler
    {
        public ParentStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "4")
            {
                OurProg.SetStrategy(new ReturnParent());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
