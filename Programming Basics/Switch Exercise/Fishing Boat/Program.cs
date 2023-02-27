using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SPRING = 3000;
            const double SUMMERANDAUTUMN = 4200;
            const double WINTER = 2600;
            int budget = int.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;

            switch (seasons)
            {
                case "Spring":
                    if (fishermans <= 6)
                    {
                        discount = SPRING * 0.1;
                        price = SPRING - discount;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        discount = SPRING * 0.15;
                        price = SPRING - discount;
                    }
                    else if (fishermans >= 12)
                    {
                        discount = SPRING * 0.25;
                        price = SPRING - discount;
                    }
                    else price = SPRING;
                    break;
                case "Summer":
                    if (fishermans <= 6)
                    {
                        discount = SUMMERANDAUTUMN * 0.1;
                        price = SUMMERANDAUTUMN - discount;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        discount = SUMMERANDAUTUMN * 0.15;
                        price = SUMMERANDAUTUMN - discount;
                    }
                    else if (fishermans >= 12)
                    {
                        discount = SUMMERANDAUTUMN * 0.25;
                        price = SUMMERANDAUTUMN - discount;
                    }
                    else price = SUMMERANDAUTUMN;
                    break;
                case "Autumn":
                    if (fishermans <= 6)
                    {
                        discount = SUMMERANDAUTUMN * 0.1;
                        price = SUMMERANDAUTUMN - discount;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        discount = SUMMERANDAUTUMN * 0.15;
                        price = SUMMERANDAUTUMN - discount;
                    }
                    else if (fishermans >= 12)
                    {
                        discount = SUMMERANDAUTUMN * 0.25;
                        price = SUMMERANDAUTUMN - discount;
                    }
                    else price = SUMMERANDAUTUMN;
                    break;
                case "Winter":
                    if (fishermans <= 6)
                    {
                        discount = WINTER * 0.1;
                        price = WINTER - discount;
                    }
                    else if (fishermans >= 7 && fishermans <= 11)
                    {
                        discount = WINTER * 0.15;
                        price = WINTER - discount;
                    }
                    else if (fishermans >= 12)
                    {
                        discount = WINTER * 0.25;
                        price = WINTER - discount;
                    }
                    else price = WINTER;
                    break;
            }
            if(fishermans % 2 == 0 && seasons != "Autumn")
            {
                price = price - (price * 0.05);
            }
            if(budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            }
            else Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
                
        }
    }
}
