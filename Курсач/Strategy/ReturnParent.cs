using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class ReturnParent : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            if (CurrentDir.ReturnParent()!=null)
            {
                OurProg.WorkWithDir(CurrentDir.ReturnParent());
            }
            else
            {
                Console.WriteLine("Действие невозможно выполнить");
            }
            
        }
    }
}
