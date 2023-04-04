using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currNum = 0;
            int times = 1;
            int maxTimes = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    times++;
                }
                else
                {
                    times = 1;
                }

                if (times > maxTimes)
                {
                    maxTimes = times;
                    currNum = numbers[i];
                }
            }
            for (int i = 1; i <= maxTimes; i++)
            {
                Console.Write(currNum + " ");
            }
        }
    }
}
