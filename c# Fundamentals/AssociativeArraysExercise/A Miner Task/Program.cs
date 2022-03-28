using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> dicitonary = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!dicitonary.ContainsKey(resource))
                {
                    dicitonary.Add(resource, quantity);
                }
                else
                {
                    dicitonary[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in dicitonary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
