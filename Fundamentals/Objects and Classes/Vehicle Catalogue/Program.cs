using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] inputInArray = input.Split("/");

                if (inputInArray[0] == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = inputInArray[1],
                        Model = inputInArray[2],
                        HorsePower = int.Parse(inputInArray[3])
                    };
                    
                    catalog.Cars.Add(car);
                   
                }
                else
                {
                    Truck truck = new Truck()
                    {
                        Brand = inputInArray[1],
                        Model = inputInArray[2],
                        Weight = int.Parse(inputInArray[3])
                    };
                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (var item in catalog.Cars.OrderBy(Car => Car.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in catalog.Trucks.OrderBy(Truck => Truck.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
