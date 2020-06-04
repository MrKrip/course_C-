using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class AddStrategy:BasicHandler
    {
        public AddStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "2")
            {
                OurProg.SetStrategy(new Add());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
