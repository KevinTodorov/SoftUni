using System;
using System.Linq;

namespace CondenceArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sum = new int[numbers.Length - 1];

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                for (int b = 0; b < numbers.Length - 1; b++)
                {
                    numbers[b] = numbers[b] + numbers[b + 1];

                    Console.WriteLine(numbers[b]);
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
