using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class KitchenFactory
    {
        Menu menu;
        public KitchenFactory()
        {
            menu = new Menu();
        }
        public IEateble GetEat(int num)
        {
            return menu.MyMenu[num % menu.MyMenu.Count];
        }
    }
}
