using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double capacity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(capacity * 0.5);
                        break;
                    case "water":
                        Console.WriteLine(capacity * 0.8);
                        break;
                    case "beer":
                        Console.WriteLine(capacity * 1.2);
                        break;
                    case "sweets":
                        Console.WriteLine(capacity * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(capacity * 1.6);
                        break;
                }
            } else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(capacity * 0.4);
                        break;
                    case "water":
                        Console.WriteLine(capacity * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(capacity * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(capacity * 1.3);
                        break;
                    case "peanuts":
                        Console.WriteLine(capacity * 1.5);
                        break;
                }

            } else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(capacity * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(capacity * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(capacity * 1.1);
                        break;
                    case "sweets":
                        Console.WriteLine(capacity * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(capacity * 1.55);
                        break;
                }
            }
            }
        }
    }

