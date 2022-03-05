using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;

            switch (type)
            {
                case "m":
                    if (sport == "Gym")
                    {
                        price = 42.00;
                    }
                    else if (sport == "Boxing")
                    {
                        price = 41.00;
                    }
                    else if (sport == "Yoga")
                    {
                        price = 45.00;
                    }
                    else if (sport == "Zumba")
                    {
                        price = 34.00;
                    }
                    else if (sport == "Dances")
                    {
                        price = 51.00;
                    }
                    else if (sport == "Pilates")
                    {
                        price = 39.00;
                    }
                    break;
                case "f":
                    if (sport == "Gym")
                    {
                        price = 35.00;
                    }
                    else if (sport == "Boxing")
                    {
                        price = 37.00;
                    }
                    else if (sport == "Yoga")
                    {
                        price = 42.00;
                    }
                    else if (sport == "Zumba")
                    {
                        price = 31.00;
                    }
                    else if (sport == "Dances")
                    {
                        price = 53.00;
                    }
                    else if (sport == "Pilates")
                    {
                        price = 37.00;
                    }
                    break;
            }

            if (age <= 19)
            {
                price -= 0.2 * price;
            }

            if (price <= sum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else Console.WriteLine($"You don't have enough money! You need ${price - sum:f2} more.");
        }
    }
}
