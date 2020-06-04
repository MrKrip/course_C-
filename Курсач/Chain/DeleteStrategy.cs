using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class DeleteStrategy:BasicHandler
    {
        public DeleteStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "5")
            {
                OurProg.SetStrategy(new Delete());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
