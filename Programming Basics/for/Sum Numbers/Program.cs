using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= rows; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
                Console.WriteLine(sum);
        }
    }
}