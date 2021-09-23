using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{//Класс номера дома в справочнике адресов, наследуется от улицы, нижний уровень адреса
    class Building : Street, IMyCloneable<Building>, ICloneable
    {
        public string BuildingNumber { get; set; }

        public Building(string cityName, string streetName, string buildingNumber) : base(cityName, streetName)
        {
            BuildingNumber = buildingNumber;
        }

        public Building MyClone()
        {
            return new Building(CityName, StreetName, BuildingNumber); 
        }

        public override string ToString()
        {
            return BuildingNumber;
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
