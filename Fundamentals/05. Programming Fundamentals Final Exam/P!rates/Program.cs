using System;
using System.Collections.Generic;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();
            string cityData = Console.ReadLine();
            while (cityData != "Sail")
            {
                string[] cityInArr = cityData.Split("||");
                string cityName = cityInArr[0];
                int population = int.Parse(cityInArr[1]);
                int gold = int.Parse(cityInArr[2]);

                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new List<int>());
                    cities[cityName].Add(population);
                    cities[cityName].Add(gold);
                }
                else
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }
                cityData = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandInArr = command.Split("=>");
                string action = commandInArr[0];
                string town = commandInArr[1];

                switch (action)
                {
                    case "Plunder":
                    {
                        int people = int.Parse(commandInArr[2]);
                        int gold = int.Parse(commandInArr[3]);

                        cities[town][0] -= people;
                        cities[town][1] -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (cities[town][0] <= 0 || cities[town][1] <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            cities.Remove(town);
                        }
                    }
                        break;
                    case "Prosper":
                    {
                        int gold = int.Parse(commandInArr[2]);

                        if (gold >= 0)
                        {
                            cities[town][1] += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                        }else Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }else Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
        }
    }
}
