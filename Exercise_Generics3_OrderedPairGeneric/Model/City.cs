using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics3_OrderedPairGeneric.Model
{
    public class City
    {
        // Properties
        public string CityName { get; set; }
        public int Population { get; set; }

        // Constructor
        public City(string cityName, int population)
        {
            CityName = cityName;
            Population = population;
        }

        // ToString
        public override string ToString()
        {
            return $"{CityName}, population: {Population}";
        }
    }
}
