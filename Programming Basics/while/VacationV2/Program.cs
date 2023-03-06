using System;

namespace VacationV2
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendingDaysCounter = 0;



            while(spendingDaysCounter != 5)
            {
                string input = Console.ReadLine();
                if(input == "save")
                {
                    double addedMoney = double.Parse(Console.ReadLine());
                    spendingDaysCounter = 0;
                    days += 1;
                    currentMoney += addedMoney;
                }else if(input == "spend")
                {
                    double spendedMoney =double.Parse(Console.ReadLine());
                    spendingDaysCounter += 1;
                    days += 1;
                   if(currentMoney - spendedMoney <= 0)
                    {
                        currentMoney = 0;
                    } else
                        
                        currentMoney -= spendedMoney;
                }
                if(currentMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
            }
            Console.WriteLine($"You can't save the money.\r\n{days}");

        }
    }
}
