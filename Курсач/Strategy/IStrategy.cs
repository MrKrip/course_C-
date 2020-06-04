using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    interface IStrategy             //Интерфейс для наших стратегий
    {       
        public void ExecuteStrategy(Component CurrentDir,Menu OurProg);
    }
}
