using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Water : IEateble
    {
        string _name;
        int _price;
        double _v;
        public Water(string name, int price, double v)
        {
            _name = name;
            _price = price;
            _v = v;
        }
        public string Eat()
        {
            return $"{_name} отлично уталяет жажду";
        }

        public string GetInfo()
        {
            return $"{_name}, объемом{_v}, Обойдется вам в {_price} рублей";
        }
        public string GetName()
        {
            return _name;
        }
    }
}
