using System;
using System.Collections.Generic;

namespace U20200911
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CarStock = new List<Car>();

            CarStock.Add(new Car { Brand = "Audi", Model = "R8", Mile = "5000", Condition = "7", Year = "2006", RegNumber = "UMP123" });
            CarStock.Add(new Car { Brand = "Volvo", Model = "V70", Mile = "15000", Condition = "5", Year = "2000", RegNumber = "YEH420" });
            CarStock.Add(new Car { Brand = "Opel", Model = "Omega", Mile = "40000", Condition = "2", Year = "1990", RegNumber = "AJJ000" });
            CarStock.Add(new Car { Brand = "Corvette", Model = "Stringray", Mile = "6000", Condition = "8", Year = "2014", RegNumber = "JMS666" });
            CarStock.Add(new Car { Brand = "SAAB", Model = "9-5 Kombi", Mile = "30000", Condition = "4", Year = "2004", RegNumber = "UMS930" });

            Console.WriteLine("Bilar i Lager: ");
            foreach (Car item in CarStock) {
                Console.WriteLine($"{item.Brand} {item.Model} ({item.RegNumber}) | År: {item.Year} | Miltal: {item.Mile} | Skick: {item.Condition}/10");
            }
        }
    }

    class Car
    {
        public string Brand{get; set;}
        public string Model { get; set; }
        public string Mile { get; set; }
        public string Condition { get; set; }
        public string Year { get; set; }
        public string RegNumber { get; set; }

    }
}
