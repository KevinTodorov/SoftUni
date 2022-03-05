using System;

namespace SuitCaseLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string luggageV = Console.ReadLine();

            double takenCapacity = 0;
            int counter = 0;
            int luggagesLoaded = 0;

            while (luggageV != "End")
            {
                double luggage = double.Parse(luggageV);
                counter++;

                if (counter == 3)
                {
                    luggage += luggage * 0.1;
                    counter = 0;
                }
                takenCapacity += luggage;

                if (takenCapacity > capacity)
                {
                    Console.WriteLine($"No more space!");
                    break;
                }

                luggagesLoaded++;
                luggageV = Console.ReadLine();
            }

            if (takenCapacity <= capacity)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {luggagesLoaded} suitcases loaded.");
        }
    }
}
