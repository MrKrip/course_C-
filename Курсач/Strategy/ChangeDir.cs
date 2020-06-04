using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class ChangeDir : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            CurrentDir.Print();
            Console.WriteLine(@"Введите название папки(без /)");
            string name = Console.ReadLine();
            if(CurrentDir.SearchInDir(name))
            {
                Component temp = CurrentDir.GetComponent(name);
                if(temp.IsDir())
                {
                    OurProg.WorkWithDir(temp);
                }
                else
                {
                    Console.WriteLine("Данное название не является названием папки");
                }
            }
            else
            {
                Console.WriteLine("Данной папки не сущетвует!!");
            }
        }
    }
}
