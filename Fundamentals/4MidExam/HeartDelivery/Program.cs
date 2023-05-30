using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDeliveryV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houseNumbers = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            int failedHouses = houseNumbers.Count;
            int lastPosition = 0;

            while (input[0] != "Love!")
            {
                int lenght = int.Parse(input[1]);
                int index = lastPosition + lenght;

                if (index < houseNumbers.Count)
                {
                    if (houseNumbers[index] == 0)
                    {
                        Console.WriteLine($"Place {index} already had Valentine's day.");
                        lastPosition = index;
                        failedHouses--;
                    }else if (houseNumbers[index] - 2 == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                        houseNumbers[index] = 0;
                        lastPosition = index;
                        failedHouses--;
                    }
                    else
                    {
                        lastPosition = index;
                        houseNumbers[index] -= 2;
                    }
                }
                else
                {
                    index = 0;
                    lastPosition = 0;
                    if (houseNumbers[index] == 0)
                    {
                        Console.WriteLine($"Place {index} already had Valentine's day.");
                        lastPosition = index;
                    }
                    else if (houseNumbers[index] - 2 == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                        houseNumbers[index] = 0;
                        lastPosition = index;
                        failedHouses--;
                    }
                    else
                    {
                        lastPosition = index;
                        houseNumbers[index] -= 2;
                    }
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            if (failedHouses > 0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
