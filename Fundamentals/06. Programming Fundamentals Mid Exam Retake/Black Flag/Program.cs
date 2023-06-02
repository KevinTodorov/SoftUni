using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    double additionalPlunder = dailyPlunder * 0.5;
                    totalPlunder += additionalPlunder;
                    totalPlunder += dailyPlunder;
                    totalPlunder -= totalPlunder * 0.3;
                    continue;
                }

                if (i % 3 == 0)
                {
                    double additionalPlunder = dailyPlunder * 0.5;
                    totalPlunder += additionalPlunder;
                    totalPlunder += dailyPlunder;
                }
                else if (i % 5 == 0)
                {
                    totalPlunder += dailyPlunder;
                    totalPlunder -= totalPlunder * 0.3;
                }
                else
                {
                    totalPlunder += dailyPlunder;
                }
               
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else if(totalPlunder < expectedPlunder)
            {
                double percentage = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
