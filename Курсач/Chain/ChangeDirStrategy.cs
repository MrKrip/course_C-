using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class ChangeDirStrategy:BasicHandler
    {
        public ChangeDirStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "3")
            {
                OurProg.SetStrategy(new ChangeDir());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
