using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public City[] ReadFirstNCitys(int nCitys)
        {
            City[] cities = new City[nCitys];

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                //read Header Line
                streamReader.ReadLine();
                for (int i = 0; i < nCitys; i++)
                {
                    string csvLine = streamReader.ReadLine();
                    cities[i] = ReadCityFromCsvLine(csvLine);
                }
            }
            return cities;
        }

        public City ReadCityFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(';');

            string cityName = parts[0];

            string cityCode = parts[1];

            string country = parts[2];

            int totalPopulation = int.Parse(parts[3]);

            int menPopulation = int.Parse(parts[4]);

            int womenPopulation = int.Parse(parts[5]);

            return new City(cityName, cityCode, country, totalPopulation, menPopulation, womenPopulation);
        }
    }
}
