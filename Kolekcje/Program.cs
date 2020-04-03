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
            #region Cz. wspólna
            string filePath = @"C:\Z_Moje Dane\Prywatne\Projekty_Prywatne\C_sharp_Kolekcje\Miasta.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> cities = csvReader.ReadAllCitys();
            #endregion
            #region LinQ

            foreach (var city in cities.OrderBy(x=>x.CityName))
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }

            #endregion
            //    Console.Write("Podaj liczbę miast do  wyświetlenia: ");

            //    bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            //    if(!inputIsInt || userInput <=0)
            //    {
            //        Console.WriteLine("Liczba musi być większa od 0");
            //        return;
            //    }

            //    // int maxToDisplay = Math.Min(userInput, cities.Count);
            //    int maxToDisplay = userInput;

            //    //for (int i = 0;  i < maxToDisplay; i++ )
            //    for (int i = cities.Count-1;  i >= 0; i-- )
            //    {
            //        int displayIndex = cities.Count - 1 - i;
            //        if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
            //        {
            //            Console.WriteLine("Naciśnij enter by kontynułować, lub wpisz coś i naciśnij enter");
            //            if (Console.ReadLine() != "")
            //                break;
            //        }

            //        City city = cities[i];
            //        Console.WriteLine($"{displayIndex + 1} : {city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //    }

            //Queue<Customer> queue = new Queue<Customer>();

            //queue.Enqueue(new Customer { Name = "Marcin" });
            //queue.Enqueue(new Customer { Name = "Tom" });
            //queue.Enqueue(new Customer { Name = "Aga" });
            //queue.Enqueue(new Customer { Name = "Ola" });
            //queue.Enqueue(new Customer { Name = "Piotr" });
            //queue.Enqueue(new Customer { Name = "Iza" });

            ////Dequeue - pobiera z koleiki i usuwa go z kolejki


            //while (queue.Count > 0)
            //{
            //    var customer = queue.Dequeue();
            //    Console.WriteLine(customer.Name);
            //    Console.WriteLine("ilość w kolejce: " + queue.Count);
            //}

            //Stack<Book> stack = new Stack<Book>();

            //stack.Push(new Book { NameBook = "Book 1" });
            //stack.Push(new Book { NameBook = "Book 2" });
            //stack.Push(new Book { NameBook = "Book 3" });
            //stack.Push(new Book { NameBook = "Book 4" });
            //stack.Push(new Book { NameBook = "Book 5" });


            //while (stack.Count > 0)
            //{
            //    var book = stack.Pop();
            //    Console.WriteLine(book.NameBook);
            //    Console.WriteLine("ilość na stosie: " + stack.Count);
            //}

            //string filePath = @"C:\Z_Moje Dane\Prywatne\Projekty_Prywatne\C_sharp_Kolekcje\Miasta.csv";

            //CsvReader csvReader = new CsvReader(filePath);

            //List<City> cities = csvReader.ReadAllCitys();

            //City cityTest = new City("Test", "Tes", "Polska", 4500, 2000, 2500);
            //int index = cities.FindIndex(city => city.TotalPopulation < 4500);
            //cities.Insert(index, cityTest);

            //cities.RemoveAt(index);

            //foreach (var city in cities)
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}



            //Console.WriteLine($"{ cities.Count} Cities");
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
