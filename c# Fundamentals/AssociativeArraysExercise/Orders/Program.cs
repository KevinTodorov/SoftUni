using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            Dictionary<string, double> productsQuantity = new Dictionary<string, double>();
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "buy")
            {
                string[] input = command.Split();
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, price);
                    productsQuantity.Add(product, quantity);
                }
                else
                {
                    products[product] = price;
                    productsQuantity[product] += quantity;
                }

                command = Console.ReadLine();
            }

            foreach (var itemProduct in products)
            {
                foreach (var quantity in productsQuantity)
                {
                    if (itemProduct.Key == quantity.Key)
                    {
                        sum = itemProduct.Value * quantity.Value;
                        Console.WriteLine($"{itemProduct.Key} -> {sum:f2}");
                    }   
                }   
            }
        }
    }
}
