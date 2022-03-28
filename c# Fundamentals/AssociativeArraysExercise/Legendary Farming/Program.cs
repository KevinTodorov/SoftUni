using System;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            legendaryItems.Add("shards", 0);
            legendaryItems.Add("motes", 0);
            legendaryItems.Add("fragments", 0);
            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            bool isLegend = false;

            while (!isLegend)
            {
                string[] command = Console.ReadLine().Split();

                for (int i = 1; i < command.Length; i+=2)
                {
                    string word = command[i].ToLower();
                    int value = int.Parse(command[i - 1]);

                    if (legendaryItems.ContainsKey(word))
                    {
                        legendaryItems[word] += value;
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(word))
                        {
                            junkItems.Add(word, value);
                        }
                        else
                        {
                            junkItems[word] += value;
                        }
                    }
                if (legendaryItems["shards"] >= 250)
                {
                    isLegend = true;
                    Console.WriteLine("Shadowmourne obtained!");
                    legendaryItems["shards"] -= 250;
                    break;;
                }else if (legendaryItems["fragments"] >= 250)
                {
                    isLegend = true;
                    Console.WriteLine("Valanyr obtained!");
                    legendaryItems["fragments"] -= 250;
                    break;;
                }else if (legendaryItems["motes"] >= 250)
                {
                    isLegend = true;
                    Console.WriteLine("Dragonwrath obtained!");
                    legendaryItems["motes"] -= 250;
                    break;
                }
                }

            }

            foreach (var item in legendaryItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
