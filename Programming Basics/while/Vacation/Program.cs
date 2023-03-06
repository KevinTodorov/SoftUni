using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double havingMoney = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int days = 0;
            

            while(spendCounter != 5)
            {
                days++;
                string movement = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if(movement == "spend")
                {
                        spendCounter++;
                    if (money > havingMoney)
                    {
                        havingMoney = 0;
                    }
                    else
                    {
                        havingMoney -= money;
                    }
                }
                else if(movement == "saved")
                {
                    havingMoney += money;
                    spendCounter = 0;
                }
                if (havingMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
                
            }
            Console.WriteLine($"You can't save the money.\r\n{days}");
        }
    }
}
