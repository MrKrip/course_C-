using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    abstract class BasicHandler : HandlerInterdace
    {
        public abstract void StrategySelection(string choise, Menu OurProg);
        protected HandlerInterdace Next;
        protected BasicHandler(HandlerInterdace next) => Next = next;
    }
}
