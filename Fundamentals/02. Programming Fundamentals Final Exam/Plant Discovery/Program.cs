using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            Dictionary<string, List<double>> ratings = new Dictionary<string, List<double>>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                string[] plant = Console.ReadLine().Split("<->").ToArray();
                string plantName = plant[0];
                double rarity = double.Parse(plant[1]);

                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, new List<double>());
                    plants[plantName].Add(rarity);
                    ratings.Add(plantName, new List<double>());
                    ratings[plantName].Add(0.0);
                }
                else plants[plantName][0] = rarity;
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandInArr = command.Split().ToArray();
                string action = commandInArr[0];
                string plant = commandInArr[1];

                switch (action)
                {
                    case "Rate:":
                    {
                        double rating = double.Parse(commandInArr[3]);

                        if (plants.ContainsKey(plant))
                        {
                            ratings[plant].Add(rating);
                        }else Console.WriteLine("error");
                    }
                        break;
                    case "Update:":
                    {
                        double newRarity = double.Parse(commandInArr[3]);

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
                            ratings[plant].Clear();
                            ratings[plant].Add(0.0);
                        }else Console.WriteLine("error");
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (var plant in plants)
            {
                string key = plant.Key;
                double averageRating = 0.0;

                if (ratings.ContainsKey(key))
                {
                    int count = ratings[key].Count - 1;
                    for (int i = 0; i < ratings[key].Count; i++)
                    {
                        averageRating += ratings[key][i];
                    }
                    averageRating /= count;
                    if (count == 0)
                    {
                        averageRating = 0;
                    }
                }
                plants[key].Add(averageRating);
            }

            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }

        }
    }
}
