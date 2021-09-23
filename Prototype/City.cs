using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{//Класс города в справочнике адресов, верхний уровень адреса
    class City : IMyCloneable<City>, ICloneable
    {
        public string CityName { get; set; }

        public City(string cityName)
        {
            CityName = cityName;
        }

        public City MyClone()
        {
            return new City(CityName);
        }

        public override string ToString()
        {
            return CityName;
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
