using System;
using System.Collections.Generic;
using System.Linq;

namespace Special_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfTires = new List<Tire[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No more tires")
                {
                    break;
                }
                string[] inputInArr = input.Split();
                var tires = new Tire[]
                {
                    new Tire(int.Parse(inputInArr[0]), double.Parse(inputInArr[1])),
                    new Tire(int.Parse(inputInArr[2]), double.Parse(inputInArr[3])),
                    new Tire(int.Parse(inputInArr[4]), double.Parse(inputInArr[5])),
                    new Tire(int.Parse(inputInArr[6]), double.Parse(inputInArr[7])),
                };
                listOfTires.Add(tires);
            }

            var listOfEngines = new List<Engine>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                {
                    break;
                }

                string[] inputInArr = input.Split();
                var engine = new Engine(int.Parse(inputInArr[0]), double.Parse(inputInArr[1]));
                listOfEngines.Add(engine);
            }

            var cars = new List<Car>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Show special")
                {
                    break;
                }
                string[] inputInArr = input.Split();
                string make = inputInArr[0];
                string model = inputInArr[1];
                int year = int.Parse(inputInArr[2]);
                double fuelQuantity = double.Parse(inputInArr[3]);
                double fuelConsumption = double.Parse(inputInArr[4]);
                int engineIndex = int.Parse(inputInArr[5]);
                int tiresIndex = int.Parse(inputInArr[6]);
              
                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engineIndex, tiresIndex));

            }

            foreach (Car car in cars)
            {
                if (car.Drive())
                {
                    if (listOfEngines[car.EngineIndex].HorsePower > 330)
                    {
                        double tirePressure = 0;
                        foreach (Tire tire in listOfTires[car.TireIndex].Where(x => x.Pressure < 10))
                        {
                            tirePressure += tire.Pressure;
                        }

                        if (tirePressure >= 9 && tirePressure <= 10)
                        {
                            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {listOfEngines[car.EngineIndex].HorsePower}\nFuelQuantity: {car.FuelQuantity:f1}");
                        }
                    }
                }
            }
        }
    }
}
