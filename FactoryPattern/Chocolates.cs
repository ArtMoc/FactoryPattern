using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Chocolates : IEateble
    {
        string _name;
        int _price;
        public Chocolates(string name, int price)
        {
            _name = name;
            _price = price;
        }
        public string Eat()
        {
            return $"{_name} шоколадный шоколад";
        }

        public string GetInfo()
        {
            return $"{_name} Обойдется вам в {_price} рублей";
        }
        public string GetName()
        {
            return _name;
        }


    }
}
