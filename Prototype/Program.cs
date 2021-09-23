using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            City city           = new City("MyCloneCity");
            Street street       = new Street(city.CityName, "MyCloneStreet");
            Building building   = new Building(street.CityName, street.StreetName, "MyCloneBuilding");

            City city1          = city.MyClone();
            Street street1      = street.MyClone();
            Building building1  = building.MyClone();

            ChangeAddress(city, "CloneCity", street, "CloneStreet", building, "CloneBuilding");            

            City city2          = (City)city.Clone();
            Street street2      = (Street) street.Clone();
            Building building2  = (Building) building.Clone();

            ChangeAddress(city, "BasicCity", street, "BasicStreet", building, "BasicBuilding");

            Console.WriteLine($"Basic : {city.ToString()} {street.ToString()} {building.ToString()}");
            Console.WriteLine($"MyClone : {city1.ToString()} {street1.ToString()} {building1.ToString()}");
            Console.WriteLine($"Clone : {city2.ToString()} {street2.ToString()} {building2.ToString()}");

            Console.ReadKey();
        }

        public static void ChangeAddress(City city, string cityName, Street street, string streetName, Building building, string buildingNumber)
        {
            city.CityName = cityName;
            street.CityName = cityName;
            street.StreetName = streetName;
            building.CityName = cityName;
            building.StreetName = streetName;
            building.BuildingNumber = buildingNumber;
        }
    }
}
