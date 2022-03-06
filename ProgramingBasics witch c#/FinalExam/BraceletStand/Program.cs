using System;

namespace BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double earnedDaileyMoney = double.Parse(Console.ReadLine());
            double allTimeSpending = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double allPocketMoney = 5 * pocketMoney;
            double allEarnedMoney = 5 * earnedDaileyMoney;
            double allMoney = allEarnedMoney + allPocketMoney;
            double afterSpendingMoney = allMoney - allTimeSpending;

            if (afterSpendingMoney >= giftPrice)
            {
                Console.WriteLine($"Profit: {afterSpendingMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice - afterSpendingMoney:f2} BGN.");
            }

        }
    }
}
