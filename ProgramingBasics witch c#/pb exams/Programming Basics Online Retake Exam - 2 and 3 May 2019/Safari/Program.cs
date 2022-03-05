using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            const double FUELLITERPRICE = 2.10;
            const double GUIDE = 100;

            double budget = double.Parse(Console.ReadLine());
            double neededFuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double sum = 0;

            double fuelPrice = neededFuel * FUELLITERPRICE;
            sum = fuelPrice + GUIDE;

            switch (day)
            {
                case "Saturday":
                    sum -= sum * 0.1;
                    break;
                case "Sunday":
                    sum -= sum * 0.2;
                    break;
            }

            if (sum <= budget)
            {
                Console.WriteLine($"Safari time! Money left: {budget - sum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {sum - budget:f2} lv.");
            }
            
        }
    }
}
