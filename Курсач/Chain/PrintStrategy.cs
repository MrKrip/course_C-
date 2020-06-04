using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class PrintStrategy : BasicHandler
    {
        public PrintStrategy(HandlerInterdace next) : base(next) { }
        public override void StrategySelection(string choise, Menu OurProg)
        {
            if (choise=="1")
            {
                OurProg.SetStrategy(new Print());
            }
            else
            {
                Next?.StrategySelection(choise, OurProg);
            }
            
        }
    }
}
