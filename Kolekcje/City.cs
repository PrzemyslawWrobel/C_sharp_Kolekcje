using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class City
    {
        public string CityName { get; }

        public string CityCode { get; }

        public string Country { get; }

        public int TotalPopulation { get; }

        public int  MenPopulation { get; }

        public int WomenPopulation { get; }

        public City(string cityName, string cityCode, string country, int totalPopulation, int menPopulation, int womenPopulation)
        {
            CityName = cityName;
            CityCode = cityCode;
            Country = country;
            TotalPopulation = totalPopulation;
            MenPopulation = menPopulation;
            WomenPopulation = womenPopulation;
        }


    }
}
