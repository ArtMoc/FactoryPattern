using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IEateble
    {
        string GetInfo();
        string Eat();
        string GetName();
    }
}
