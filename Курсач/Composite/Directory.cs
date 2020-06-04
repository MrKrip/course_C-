using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Directory : Component
    {
        private List<Component> components = new List<Component>();
        public Directory(string name,Component parent) : base(name,parent) { }
        public override void Add(Component component) { components.Add(component); }
        public override void Remove(Component component) { components.Remove(component); }
        public override void Print() {
            Console.WriteLine(@"Текущая дериктория -> " + name);
            Console.WriteLine("Подузлы:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print2();
            }
        }
        public override bool SearchInDir(string name)
        {
            foreach(var elem in components)
            {
                if(elem.GetName()==name)
                {
                    return true;
                }
            }
            return false;
        }


        public override Component GetComponent(string name)
        {
            for(int i=0;i<components.Count;i++)
            {
                if(components[i].GetName()==name)
                {
                    return components[i];
                }
            }
            return this;
        }
        public override  Component ChangeHelper(int i)
        {
            return components[i];
        }

    }
}
