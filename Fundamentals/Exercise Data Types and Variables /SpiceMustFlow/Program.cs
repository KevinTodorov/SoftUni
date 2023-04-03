using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YIELDEATENBYWORKERS = 26;
            
            uint startingYield = uint.Parse(Console.ReadLine());

            uint extractedYield = 0;

            int daysCounter = 0;

            while (startingYield >= 100)
            {
                if (YIELDEATENBYWORKERS > startingYield)
                {
                    extractedYield += YIELDEATENBYWORKERS;
                }

                extractedYield += startingYield - YIELDEATENBYWORKERS;

                startingYield -= 10;

                daysCounter++;
            }
            Console.WriteLine(daysCounter);

            if (YIELDEATENBYWORKERS > startingYield)
            {
                extractedYield += YIELDEATENBYWORKERS;
            }

            Console.WriteLine(extractedYield - YIELDEATENBYWORKERS);
        }
    }
}
