using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double price = 0;

            for (int i = 1; i <= days; i++)
            {
                double sum = 0;

                for (int b = 1; b <= hours; b++)
                {

                    if (i % 2 == 0 && b % 2 != 0)
                    {
                        sum += 2.50;
                    }
                    else if (i % 2 != 0 && b % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                    price += sum;

                Console.WriteLine($"Day: {i} - {sum:f2} leva");
            }

            Console.WriteLine($"Total: {price:f2} leva");
        }
    }
}
