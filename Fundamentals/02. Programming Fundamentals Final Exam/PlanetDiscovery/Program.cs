using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            Dictionary<string, List<double>> rating = new Dictionary<string, List<double>>();
            for (int i = 0; i < lines; i++)
            {
                string[] foundedPlant = Console.ReadLine().Split("<->").ToArray();
                string plant = foundedPlant[0];
                double rarity = double.Parse(foundedPlant[1]);
                if (plants.ContainsKey(plant))
                {
                    plants[plant][0] = rarity;
                }
                else
                {
                    plants.Add(plant, new List<double>());
                    plants[plant].Add(rarity);
                }
            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] commands = input.Split();
                string action = commands[0];
                string plant = commands[1];

                switch (action)
                {
                    case "Rate:":
                    {
                        double ratings = double.Parse(commands[3]);
                        if (plants.ContainsKey(plant))
                        {
                            if (!rating.ContainsKey(plant))
                            {
                                rating.Add(plant, new List<double>());
                            }
                            rating[plant].Add(ratings);
                        }else Console.WriteLine("error");
                    }
                        break;
                    case "Update:":
                    {
                        double newRarity = double.Parse(commands[3]);
                        if (plants.ContainsKey(plant))
                        {
                            plants[plant][0] = newRarity;
                        }else Console.WriteLine("error");
                    }
                        break;
                    case "Reset:":
                    {
                        if (plants.ContainsKey(plant))
                        {
                            if (rating.ContainsKey(plant))
                            {
                                rating[plant].Clear();
                                rating[plant].Add(0.00);
                            }
                        }else Console.WriteLine("error");
                    }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var plant in plants)
            {
                foreach (var key in rating)
                {
                    if (plant.Key.Equals(key.Key))
                    {
                        double averageRating = 0;
                        for (int i = 0; i < key.Value.Count; i++)
                        {
                            averageRating += key.Value[i];
                        }
                        averageRating /= key.Value.Count;
                        plant.Value.Add(averageRating);
                    }
                }
            }

            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }

       
    }
}
