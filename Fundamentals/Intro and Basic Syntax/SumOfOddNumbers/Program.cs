using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= times; i++)
            {
                if (i % 2 != 0)
                {
                    times += 1;
                    sum += i;
                    Console.WriteLine(i);
                }               
            }
            Console.WriteLine(sum);
        }
    }
}
