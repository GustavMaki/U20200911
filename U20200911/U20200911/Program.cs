using System;
using System.Collections.Generic;
using System.Linq;

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
                string Mile = Console.ReadLine();

                Console.Write("Skick(1-10): ");
                string Condition = Console.ReadLine();

                Console.Write("År: ");
                string Year = Console.ReadLine();

                CarStock.Add(new Car { Brand = Brand , Model = Model, Mile = Mile, Condition = Condition, Year = Year, RegNumber = RegNumber });

                Console.WriteLine();
            }

            Console.WriteLine("Uppdaterad Lagerlista: ");
            Console.WriteLine($" Antal Bilar: {CarStock.Count()}");
            Console.WriteLine();

            foreach (Car item in CarStock)
            {
                Console.WriteLine($"{item.Brand} {item.Model} ({item.RegNumber}) | År: {item.Year} | Miltal: {item.Mile} | Skick: {item.Condition}/10");
            }

            Console.WriteLine();

            Console.WriteLine("Sök i Listan");
            Console.Write("Bilmärke: ");
            string SearchBrand = Console.ReadLine();

            foreach (Car item in CarStock.FindAll(x => x.Brand == SearchBrand))
            {
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
