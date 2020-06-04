using System;
using System.Collections.Generic;
using System.Text;

namespace Курсач
{
    class File:Component
    {
        public File(string name, Component parent) : base(name, parent) { }
        public override bool IsDir()
        {
            return false;
        }
    }
}
