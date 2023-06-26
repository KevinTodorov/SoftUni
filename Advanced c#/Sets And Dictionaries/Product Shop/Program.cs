using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] commandInArray = command.Split();
                string shopName = commandInArray[0];
                shopName = shopName.Remove(shopName.Length - 1, 1);
                string product = commandInArray[1];
                double price = double.Parse(commandInArray[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                    shops[shopName].Add(product, price);
                }else shops[shopName].Add(product, price);
                command = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key} Price: {product.Value:f1}");
                }
            }
        }
    }
}
