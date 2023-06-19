using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] amountsOfCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] amountOfBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(amountsOfCups);
            Stack<int> bottles = new Stack<int>(amountOfBottles);
            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentBottle = bottles.Peek();
                int currentCup = cups.Peek();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    bottles.Pop();
                    cups.Dequeue();
                }else if (currentCup > currentBottle)
                {
                    while (currentCup > 0)
                    {
                        currentCup -= currentBottle;
                        bottles.Pop();
                        if (bottles.Count > 0)
                        {
                            currentBottle = bottles.Peek();
                        }

                        if (currentCup <= currentBottle)
                        {
                            wastedWater += currentBottle - currentCup;
                            cups.Dequeue();
                            bottles.Pop();
                            break;
                        }
                    }
                }

            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
