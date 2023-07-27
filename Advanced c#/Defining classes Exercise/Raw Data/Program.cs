using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Raw_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var car = new List<Car>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tires = new Tire[4]
                {
                    new Tire(double.Parse(input[5]), int.Parse(input[6])),
                    new Tire(double.Parse(input[7]), int.Parse(input[8])),
                    new Tire(double.Parse(input[9]), int.Parse(input[10])),
                    new Tire(double.Parse(input[11]), int.Parse(input[12]))
                };
                car.Add(new Car(model, engine, cargo, tires));
            }

            string type = Console.ReadLine();
            var filteredCars = new List<Car>();
            if (type == "fragile")
            {
                filteredCars = car.Where(c => c.Cargo.Type == type && c.Tires.Any(c => c.TirePressure < 1)).ToList();
            }
            else filteredCars = car.Where(c => c.Cargo.Type == type && c.Engine.Power >= 250).ToList();

            foreach (Car cars in filteredCars)
            {
                Console.WriteLine(cars.Model);
            }

        }
    }
}
