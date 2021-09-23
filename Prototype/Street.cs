using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{//Класс улицы в справочнике адресов, наследуется от города
    class Street : City, IMyCloneable<Street>, ICloneable
    {
        public string StreetName { get; set; }

        public Street(string cityName, string streetName) : base (cityName)
        {
            StreetName = streetName;
        }

        public Street MyClone()
        {
            return new Street(CityName, StreetName);
        }

        public override string ToString()
        {
            return StreetName;
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
