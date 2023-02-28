using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += number;
                }
                else odd += number;
            }
            if(even == odd)
            {
                Console.WriteLine($"Yes\r\nSum = {even}");
            }
            else Console.WriteLine($"No\r\nDiff = {Math.Abs(even - odd)}");
        }
    }
}
