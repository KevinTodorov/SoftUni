using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentN = i;

                int sum = 0;
                while (currentN > 0)
                {
                    sum += currentN % 10;
                    currentN /= 10;
                }

                bool specialN = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {specialN}");
            }
        }
    }
}
