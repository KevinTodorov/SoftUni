using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                double lastSum = 0;

                if (i + 1 > numbers.Count - 1)
                {
                    break;
                }

                if (numbers[i] == numbers[i + 1])
                {
                    if (i > 0)
                    {
                      if (numbers[i - 1] == numbers[i] && numbers[i]== numbers[i + 1])
                      {
                        lastSum = numbers[i - 1] + numbers[i];
                        numbers.RemoveAt(i - 1);
                        numbers[i - 1] = lastSum;
                        i = 0;
                            i--;
                        continue;
                      }
                    }
                    lastSum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers[i] = lastSum;
                    i = 0;
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
