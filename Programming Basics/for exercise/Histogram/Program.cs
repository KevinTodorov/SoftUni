using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number < 200)
                {
                    p1++;
                }else if (number <= 399 && number >= 200)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }
            double Precentage1 = (double)p1 / n * 100;
            double Precentage2 = (double)p2 / n * 100;
            double Precentage3 = (double)p3 / n * 100;
            double Precentage4 = (double)p4 / n * 100;
            double Precentage5 = (double)p5 / n * 100;

            Console.WriteLine($"{Precentage1:f2}%");
            Console.WriteLine($"{Precentage2:f2}%");
            Console.WriteLine($"{Precentage3:f2}%");
            Console.WriteLine($"{Precentage4:f2}%");
            Console.WriteLine($"{Precentage5:f2}%");
        }
    }
}