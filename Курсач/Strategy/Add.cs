using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Add : IStrategy       //Стратегия для добавления фала\папки
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            Console.WriteLine("1)Создать папку\n2)Создать файл");
            Console.WriteLine("Ваш выбор :");
            string choise=Console.ReadLine();           
            switch (choise)
            {
                case "1":
                    CreateDir(CurrentDir);      //Вызов функции создания папки
                    break;
                case "2":
                    CreateFile(CurrentDir);     //Вызов функции создания файла
                    break;
                default :
                    {
                        Console.WriteLine("Вы нажади неизвестную кнопку");
                    };
                    break;
            }
        }

        private void CreateDir(Component CurrentDir)        //Функция для создания папки
        {
            Console.WriteLine("Введите название папки");
            string name=Console.ReadLine();
            if(name.Contains("/")|| name.Contains(@"\") || name.Contains("|") || name.Contains(":") || name.Contains(".") || name.Contains("?") || name.Contains("*") || name.Contains("<") || name.Contains(">") || name.Contains("\""))  
                //Проверка имени папки на недопустимы символы
            {
                Console.WriteLine("Недопустимое название(не должно содеожать . / | : ? * < > \""+ @" \ )");
            }
            else 
            {
                if(CurrentDir.SearchInDir(name))            //Проверка на существование папки с таким именем в нашей директории
                {
                    Console.WriteLine("Данная директория уже существует");
                }
                else
                {
                    CurrentDir.Add(new Directory(name,CurrentDir));
                }                
            }
        }

        private void CreateFile(Component CurrentDir) //Функция для создания файла
        {
            Console.WriteLine("Введите название файла");
            string name = Console.ReadLine();
            if (name.Contains("/") || name.Contains(@"\") || name.Contains("|") || name.Contains(":") || !name.Contains(".") || name.Contains("?") || name.Contains("*") || name.Contains("<") || name.Contains(">") || name.Contains("\""))
            //Проверка имени файла на недопустимы символы
            {
                Console.WriteLine("Недопустимое название(не должно содеожать / | : ? * < > \"" + @" \ и должно содержать .)");
            }
            else
            {
                if (CurrentDir.SearchInDir(name)) //Проверка на существование файла с таким именем в нашей директории
                {
                    Console.WriteLine("Данный файл уже существует");
                }
                else
                {
                    CurrentDir.Add(new File(name, CurrentDir));
                }                
            }
        }
    }
}
