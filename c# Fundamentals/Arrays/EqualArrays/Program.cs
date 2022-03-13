using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                int currNum1 = firstArr[i];
                int currNum2 = secondArr[i];

                if (currNum1 == currNum2)
                {
                    sum += currNum1;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
