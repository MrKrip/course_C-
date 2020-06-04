using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Cut : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            CurrentDir.Print();
            Console.WriteLine(@"Введите название фйла/папки(без /)");
            string name = Console.ReadLine();
            if (CurrentDir.SearchInDir(name))
            {
                Component temp = CurrentDir.GetComponent(name);
                OurProg.Buffer = temp;
                CurrentDir.Remove(temp);
            }
            else
            {
                Console.WriteLine("Данной папки/файла не сущетвует!!");
            }
        }
    }
}
