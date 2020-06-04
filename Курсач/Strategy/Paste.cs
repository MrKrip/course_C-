using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Paste : IStrategy
    {
        public void ExecuteStrategy(Component CurrentDir, Menu OurProg)
        {
            if(OurProg.Buffer!=null)
            {   
                if(CurrentDir.SearchInDir(OurProg.Buffer.GetName()))
                {
                    string name = OurProg.Buffer.GetName();
                    OurProg.Buffer.SetName(name+"(Вставка)");
                    CurrentDir.Add(OurProg.Buffer);
                    OurProg.Buffer = null;
                }
                else
                {
                    CurrentDir.Add(OurProg.Buffer);
                    OurProg.Buffer = null;
                }
            }
            else 
            {
                Console.WriteLine("Нечего вставлять из буфера обмена");
            }
        }
    }
}
