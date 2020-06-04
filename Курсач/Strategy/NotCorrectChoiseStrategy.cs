using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class NotCorrectChoiseStrategy : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            Console.WriteLine("Введненный выбор не коректный!!");
        }
    }
}
