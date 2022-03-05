using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counter = 0;
            int boughtToys = 0;
            double sum = 0;

            while (command != "Stop")
            {
                double price = double.Parse(Console.ReadLine());
                boughtToys++;
                counter++;

                if (counter == 3)
                {
                    counter = 0;
                    price /= 2;
                }

                if (price > budget)
                {
                    Console.WriteLine($"You don't have enough money!\r\nYou need {price - budget:f2} leva!");
                    return;
                }
                budget -= price;
                sum += price;

                command = Console.ReadLine();
            }

            if (command == "Stop")
            {
                Console.WriteLine($"You bought {boughtToys} products for {sum:f2} leva.");
            }

        }
    }
}
