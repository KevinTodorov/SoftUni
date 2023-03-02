using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if(number > max)
                {
                    max = number;
                }
            }
            int sumWithoutMax = sum - max;
            if(max == sumWithoutMax)
            {
                Console.WriteLine($"Yes\r\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(sumWithoutMax - max)}");
            }
        }
    }
}
