using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumbers[0])
                {
                    for (int j = 0; j < specialNumbers[1]; j++)
                    {
                        if (i - 1 >= 0)
                        {
                            numbers.RemoveAt(i - 1);
                            i--;
                        }
                    }
                    for (int c = 0; c < specialNumbers[1]; c++)
                    {
                        if (i + 1 < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);                          
                        }
                    }
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
