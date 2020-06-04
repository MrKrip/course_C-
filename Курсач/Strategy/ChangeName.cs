using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class ChangeName : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            CurrentDir.Print();
            Console.WriteLine(@"Введите название фйла/папки(без /)");
            string name = Console.ReadLine();
            if (CurrentDir.SearchInDir(name))
            {
                Component temp = CurrentDir.GetComponent(name);
                Console.WriteLine("Введите новое имя фйла/папки");
                name = Console.ReadLine();
                if (name.Contains("/") || name.Contains(@"\") || name.Contains("|") || name.Contains(":") || name.Contains(".") || name.Contains("?") || name.Contains("*") || name.Contains("<") || name.Contains(">") || name.Contains("\"") )
                {
                    Console.WriteLine("Недопустимое название(не должно содеожать . / | : ? * < > \"" + @" \ )");
                }
                else
                {
                    if(CurrentDir.SearchInDir(name))
                    {
                        Console.WriteLine("Папка/файл с даным именем уже существоет в даной дериктории");
                    }
                    else
                    {
                        temp.SetName(name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Данной папки/файла не сущетвует!!");
            }
        }
    }
}
