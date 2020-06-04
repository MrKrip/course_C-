using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class NotCorrectChoise:BasicHandler
    {
        public NotCorrectChoise(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            OurProg.SetStrategy(new NotCorrectChoiseStrategy());
        }
    }
}
