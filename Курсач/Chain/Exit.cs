using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Exit:BasicHandler
    {
        public Exit(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }

        }
    }
}
