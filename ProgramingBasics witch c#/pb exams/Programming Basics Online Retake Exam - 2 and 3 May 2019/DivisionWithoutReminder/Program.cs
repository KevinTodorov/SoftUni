using System;

namespace DivisionWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1 ++;
                }
               if (number % 3 == 0)
                {
                    p2 ++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
                double p1Percents = (p1 / n) * 100;
                double p2Percents = (p2 / n) * 100;
                double p3Percents = (p3 / n) * 100;

                Console.WriteLine($"{p1Percents:f2}%\r\n{p2Percents:f2}%\r\n{p3Percents:f2}%");
        }
    }
}
