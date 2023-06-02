using System;

namespace Black_FlagV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
            int threeDaysCounter = 1;
            int fiveDaysCounter = 1;

            for (int i = 1; i <= days; i++)
            {
                if (threeDaysCounter == 3)
                {
                    totalPlunder += dailyPlunder + (dailyPlunder * 0.5);
                    threeDaysCounter = 1;
                    fiveDaysCounter++;
                }else if (fiveDaysCounter == 5)
                {
                    totalPlunder += dailyPlunder;
                    double lostPlunder = totalPlunder * 0.3;
                    totalPlunder -= lostPlunder;
                    fiveDaysCounter = 1;
                    threeDaysCounter++;
                }
                else
                {
                    totalPlunder += dailyPlunder;
                    threeDaysCounter++;
                    fiveDaysCounter++;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentages = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentages:f2}% of the plunder.");
            }
        }
    }
}
