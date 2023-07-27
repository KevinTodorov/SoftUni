using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Car_Salesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                int displacement = int.Parse(input[2]);
                if (input.Length == 3)
                {
                    engines.Add(new Engine(model, power, displacement));
                }
                else
                {
                    string efficiency = input[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new Car[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                var engine = engines.Find(e => e.Model == engineModel);
                if (input.Length == 2)
                {
                    cars[i] = new Car(model, engine);
                }else if (input.Length == 3)
                {
                    string weight = input[2];
                    cars[i] = new Car(model, engine, weight);
                }
                else
                {
                    string weight = input[2];
                    string color = input[3];
                    cars[i] = new Car(model, engine, weight, color);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:\n {car.Engine.Model}:\n  Power: {car.Engine.Power}\n  Displacement: {car.Engine.Displacement}\n  Efficiency: {car.Engine.Efficiency}\n Weight: {car.Weight}\n Color: {car.Color}");
            }
        }
    }
}
