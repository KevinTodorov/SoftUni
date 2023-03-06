using System;

namespace Vacation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double currMon = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCounter = 0;

            while (spendCounter != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if(input == "save")
                {
                    currMon += money;
                    spendCounter = 0;
                }
                else if(input == "spend")
                {
                    spendCounter++;
                    if(money > currMon)
                    {
                        currMon = 0;
                    }
                    else
                    {
                        currMon -= money;
                    }
                }
                if(currMon >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
            }
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
        }
    }
}
