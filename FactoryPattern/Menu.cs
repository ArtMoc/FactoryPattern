using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Menu
    {
        public List<IEateble> MyMenu { get; set; }
        public Menu()
        {
            MyMenu = new List<IEateble>()
            {
                new IceCream("Вафельный стаканчик", 20),
                new IceCream("Эскимо", 50),
                new IceCream("Крем-брюле",30),
                new Water("Кока-кола",80,0.5),
                new Water("Боржоми",150,1),
                new Chocolates("Аленка",100),
                new Chocolates("Мишка на севере",150)
            };
        }
    }
}
