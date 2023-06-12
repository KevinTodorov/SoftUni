using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 0; i < lines; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                string carModel = car[0];
                int mileage = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);
                cars.Add(carModel, new List<int>());
                cars[carModel].Add(mileage);
                cars[carModel].Add(fuel);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandInArray = command.Split(" : ");
                string action = commandInArray[0];
                string car = commandInArray[1];

                switch (action)
                {
                    case "Drive":
                    {
                        int distance = int.Parse(commandInArray[2]);
                        int fuel = int.Parse(commandInArray[3]);

                        if (cars.ContainsKey(car))
                        {
                            if (cars[car][1] - fuel > 0)
                            {
                                cars[car][0] += distance;
                                cars[car][1] -= fuel;

                                Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                                if (cars[car][0] >= 100000)
                                {
                                    cars.Remove(car);
                                    Console.WriteLine($"Time to sell the {car}!");
                                    continue;
                                }
                            }else Console.WriteLine("Not enough fuel to make that ride");
                        }
                    }
                        break;
                    case "Refuel":
                    {
                        int fuel = int.Parse(commandInArray[2]);
                        int refilledFuel = 0;

                        if (cars[car][1] + fuel > 75)
                        {
                            while (cars[car][1] < 75)
                            {
                                cars[car][1] += 1;
                                refilledFuel++;
                            }
                        }
                        else
                        {
                            refilledFuel = fuel;
                            cars[car][1] += fuel;
                        }

                        Console.WriteLine($"{car} refueled with {refilledFuel} liters");
                    }
                        break;
                    case "Revert":
                    {
                        int kilometers = int.Parse(commandInArray[2]);

                        if (cars[car][0] - kilometers < 10000)
                        {
                            cars[car][0] = 10000;
                        }
                        else
                        {
                            cars[car][0] -= kilometers;
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                    }
                        break;
                }

                command = Console.ReadLine();
            }

            //cars = new Dictionary<string, List<int>>(cars.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key));

            foreach (var car in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
