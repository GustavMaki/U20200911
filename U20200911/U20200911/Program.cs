using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace U20200911
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CarStock = new List<Car>();

            CarStock.Add(new Car { Mile = 5000, Brand = "Audi", Model = "R8", Condition = "7", Year = "2006", RegNumber = "UMP123" });
            CarStock.Add(new Car { Mile = 15000, Brand = "Volvo", Model = "V70", Condition = "5", Year = "2000", RegNumber = "YEH420" });
            CarStock.Add(new Car { Mile = 40000, Brand = "Opel", Model = "Omega", Condition = "2", Year = "1990", RegNumber = "AJJ000" });
            CarStock.Add(new Car { Mile = 6000, Brand = "Corvette", Model = "Stringray", Condition = "8", Year = "2014", RegNumber = "JMS666" });
            CarStock.Add(new Car { Mile = 30000, Brand = "SAAB", Model = "9-5 Kombi", Condition = "4", Year = "2004", RegNumber = "UMS930" });

            Console.WriteLine("Lagerlista: ");
            foreach (Car item in CarStock) {
                Console.WriteLine($"{item.Brand} {item.Model} ({item.RegNumber}) | År: {item.Year} | Miltal: {item.Mile} | Skick: {item.Condition}/10");
            }

            Console.WriteLine();

            Console.Write("Hur många bilar vill du lägga till?:");
            string Number = Console.ReadLine();
            int CarAdd = int.Parse(Number);
            int i = 0;

            Console.WriteLine();

            for (i = 0; i < CarAdd; i++) {
                Console.WriteLine($"Bil({i+1})");

                Console.Write("Märke: ");
                string Brand = Console.ReadLine();

                Console.Write("Modell: ");
                string Model = Console.ReadLine();

                Console.Write("Reg Nummer: ");
                string RegNumber = Console.ReadLine();

                Console.Write("Miltal: ");
                string StrMile = Console.ReadLine();
                int Mile = int.Parse(StrMile);


                Console.Write("Skick(1-10): ");
                string Condition = Console.ReadLine();

                Console.Write("År: ");
                string Year = Console.ReadLine();

                CarStock.Add(new Car { Mile = Mile, Brand = Brand , Model = Model, Condition = Condition, Year = Year, RegNumber = RegNumber });

                Console.WriteLine();
            }

            Console.WriteLine("Uppdaterad Lagerlista: ");
            Console.WriteLine($"Antal Bilar: {CarStock.Count()}");
            Console.WriteLine();

            foreach (Car item in CarStock)
            {
                Console.WriteLine($"{item.Brand} {item.Model} ({item.RegNumber}) | År: {item.Year} | Miltal: {item.Mile} | Skick: {item.Condition}/10");
            }

            Console.WriteLine();

            Console.WriteLine("Sök i Lagerlista");
            Console.Write("Bilmärke: ");
            string SearchBrand = Console.ReadLine();
            int SearchCount = 0;

            foreach (Car item in CarStock.FindAll(x => x.Brand == SearchBrand))
            {
                SearchCount++;
                Console.WriteLine($"{item.Brand} {item.Model} ({item.RegNumber}) | År: {item.Year} | Miltal: {item.Mile} | Skick: {item.Condition}/10");
            }
            Console.WriteLine($"Antal Bilar: {SearchCount}");

            Console.WriteLine();
            
            Console.WriteLine("Lagerlista sorterad efter Miltal:");

            foreach (Car item in CarStock.OrderByDescending(item => item.Mile))
            {
                Console.WriteLine($"{item.Brand} {item.Model} ({item.RegNumber}) | År: {item.Year} | Miltal: {item.Mile} | Skick: {item.Condition}/10");
            }

        }
    }

    class Car
    {
        public string Brand{get; set;}
        public string Model { get; set; }
        public int Mile { get; set; }
        public string Condition { get; set; }
        public string Year { get; set; }
        public string RegNumber { get; set; }

    }
}
