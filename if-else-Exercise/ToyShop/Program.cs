using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double talkingDoll = 3.00;
            const double bear = 4.10;
            const double minion = 8.20;
            const double truck = 2.00;

            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pzPrice = puzzlePrice * puzzles;
            double tkDollPrice = talkingDoll * talkingDolls;
            double bearPrice = bear * bears;
            double minionsPrice = minion * minions;
            double trucksPrice = truck * trucks;

            double sum = pzPrice + tkDollPrice + bearPrice + minionsPrice + trucksPrice;
            int toysNumber = puzzles + talkingDolls + bears + minions + trucks;
            if(toysNumber >= 50)
            {
                sum = sum - (sum * 0.25);
                double rent = sum * 0.1;
                sum -= rent;

            }else if (toysNumber < 50)
            {
                double rent = sum * 0.1;
                sum -= rent;
            }if(sum > holidayPrice)
            {
                Console.WriteLine($"Yes! {(sum - holidayPrice):f2} lv left.");
            }
            else Console.WriteLine($"Not enough money! {(holidayPrice - sum):f2} lv needed.");
               


        }
    }
}
