using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics2_OrderedPairNonGeneric.Model
{
    public class City
    {

        private string cityName;
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        private int population;
        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public City(string cityName, int population)
        {
            CityName = cityName;
            Population = population;
        }

        public override string ToString()
        {
            string cityText = $"{CityName}, population: {Population}";
            return cityText;
        }

    }
}
