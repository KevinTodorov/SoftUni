using System;

namespace ToyShopV2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PUZZLE = 2.60;
            const double DOLL = 3.00;
            const double BEAR = 4.10;
            const double MINION = 8.20;
            const double TRUCK = 2.00;

            double price = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = PUZZLE * puzzles;
            double dollPrice = DOLL * dolls;
            double bearPrice = BEAR * bears;
            double minionPrice = MINION * minions;
            double truckPrice = TRUCK * trucks;
            double allTogetherPrice = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;
            int allToys = puzzles + dolls + bears + minions + trucks;

            if (allToys >= 50)
            {
                allTogetherPrice -= allTogetherPrice * 0.25;
            }

            double sumAfterRent = allTogetherPrice - (allTogetherPrice * 0.1);
            if (sumAfterRent >= price)
            {
                Console.WriteLine($"Yes! {(sumAfterRent - price):f2} lv left.");
            }else
                Console.WriteLine($"Not enough money! {(price - sumAfterRent):f2} lv needed.");
        }
    }
}
