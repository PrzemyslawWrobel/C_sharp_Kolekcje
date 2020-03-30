using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader( string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public City[] ReadFirstNCitys(int nCitys)
        {
            City[] cities = new City[nCitys  ];
            return cities;
        }
    }
}
