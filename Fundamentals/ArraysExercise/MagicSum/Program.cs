using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            string save = String.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int b = i + 1;  b < numbers.Length;  b++)
                {
                    if (numbers[i] + numbers[b] == sum)
                    {
                        Console.Write(numbers[i] + " " + numbers[b]);
                        Console.WriteLine();
                    }
                }
            }         
        }
    }
}
