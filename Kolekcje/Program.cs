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
            string[] monthsOfYear =
            {
                "January",
                "February",
                "March",
                "April",
                "Maj",
                "June",
                "Julay",
                "August",
                "September",
                "October",
                "November",
                "Desember",

            };


            Console.WriteLine(" Jaki chcesz wyśw miesiąc ?");
            Console.WriteLine("Januar =1, February = 2 etc : ");

            int month = int.Parse(Console.ReadLine())-1;
            string chosenMonth = monthsOfYear[month];
            Console.WriteLine($"Wybrany miesiąc to: {chosenMonth}");

            //foreach (var month in monthsOfYear)
            //{
            //    Console.WriteLine(month);
               

            //}
            Console.ReadKey();
        }
    }
}
