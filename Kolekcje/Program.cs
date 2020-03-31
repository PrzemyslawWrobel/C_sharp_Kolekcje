using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Z_Moje Dane\Prywatne\Projekty_Prywatne\C_sharp_Kolekcje\Miasta.csv";


            CsvReader csvReader = new CsvReader(filePath);
            City[] cities = csvReader.ReadFirstNCitys(7);
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        //{
        //    string[] monthsOfYear =
        //    {
        //        "January",
        //        "February",
        //        "March",
        //        "April",
        //        "Maj",
        //        "June",
        //        "Julay",
        //        "August",
        //        "September",
        //        "October",
        //        "November",
        //        "Desember",

            //    };


            //    Console.WriteLine(" Jaki chcesz wyśw miesiąc ?");
            //    Console.WriteLine("Januar =1, February = 2 etc : ");

            //    int month = int.Parse(Console.ReadLine())-1;
            //    if(month <1)
            //    {
            //        Console.WriteLine("Nr miesiąca musi być większy od 0");
            //        Console.WriteLine("Podaj miesiąc");
            //        month = int.Parse(Console.ReadLine()) - 1;
            //    } else if (month > 11){
            //        Console.WriteLine("Nr miesiąca musi być mniejszy lub równy 12");
            //        Console.WriteLine("Podaj miesiąc");
            //        month = int.Parse(Console.ReadLine()) - 1;
            //    } else
            //    {
            //        string chosenMonth = monthsOfYear[month];
            //        Console.WriteLine($"Wybrany miesiąc to: {chosenMonth}");
            //    }



            //    //foreach (var month in monthsOfYear)
            //    //{
            //    //    Console.WriteLine(month);


            //    //}
               Console.ReadKey();
        }
    }
}
