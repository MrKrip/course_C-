using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Menu
    {
        private Component tree = new Directory(@"С:/",null); //Создаем основу нашей "Файловой системы"
        public Component Buffer = null;                      //Буфер для переноски файлов
        private IStrategy MyStrategy;                        //Переменная куда будут записывать кончкретные стратегии
        private string choise;                              //Переменная для выборов
        private HandlerInterdace chain = new PrintStrategy(
                                             new AddStrategy(
                                              new ChangeDirStrategy(
                                                   new ParentStrategy(
                                                      new DeleteStrategy(
                                                          new CutStrategy(
                                                              new PasteStrategy(
                                                                  new ReNameStrategy(
                                                                      new Exit(new NotCorrectChoise(null))))))))));       //Задаем цепочку для выбора стратегии
        public void SetStrategy(IStrategy strategy)         //Функция для установки стратегии
        {
            this.MyStrategy = strategy;
        }
        public void Start()                                 
        {
            WorkWithDir(tree);
        }
       
        public void WorkWithDir(Component CurrentDir)   //Основная функция и меню пользователя
        {
            Console.WriteLine();            
            Console.WriteLine("1)Вывести текущую папку и ее содержание на экран\n2)Создать новый файл/папку\n3)Перейти в другую папку\n4)Вернутся в предыдущую папку\n5)Удалить файл/папку\n6)Вырезать файл/папку из текущей папки\n7)Вставить файл/папку в текущую папку\n8)Переименовать файл/папку\n0)Exit\n");
            Console.WriteLine("Ваш выбор : ");
            choise = Console.ReadLine();
            Console.WriteLine();

            chain.StrategySelection(choise,this);           //Проход по цепочки для выбора стратегии
            Console.Clear();
            MyStrategy.ExecuteStrategy(CurrentDir,this);        //Выполнение выбранной стратегии
            WorkWithDir(CurrentDir);            //Возвращаемся в эту же функцию(выход из программы в команде Exit цепочки)
        }

    }
}
