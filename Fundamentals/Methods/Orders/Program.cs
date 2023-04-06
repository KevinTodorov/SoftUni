using System;

namespace Orders
{
    class Program
    {
        const double COFFEE = 1.50;
        const double WATER = 1.00;
        const double COKE = 1.40;
        const double SNACKS = 2.00;
        static void Main(string[] args)
        {
            Shop(Console.ReadLine(), double.Parse(Console.ReadLine()));
        }

        static void Shop(string item, double purchases)
        {
            switch (item)
            {
                case "coffee":
                    Console.WriteLine($"{COFFEE * purchases:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{COKE * purchases:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{WATER * purchases:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{SNACKS * purchases:f2}");
                    break;
            }
        }
    }
}
