using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class Component
    {
        protected string name;
        protected Component parent;
        public Component(string name,Component parent) { this.name = name; this.parent = parent; }
        public virtual void Add(Component component) { }
        public virtual string GetName() { return name; }
        public virtual void SetName(string name) { this.name = name; }
        public virtual void Remove(Component component) { }
        public virtual void Print() { Console.WriteLine(name); }
        public virtual void Print2() { Console.WriteLine("\t/"+name); }
        public virtual Component ChangeHelper(int i) { return this ; }
        public virtual bool SearchInDir(string name) { return false; }
        public virtual bool IsDir() { return true; }
        public virtual Component GetComponent(string name) { return this; }
        public virtual Component ReturnParent() { return parent; }

    }
}
