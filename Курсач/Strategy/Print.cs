using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Print : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir,Menu OurProg)
        {
            CurrentDir.Print();
        }
    }
}
