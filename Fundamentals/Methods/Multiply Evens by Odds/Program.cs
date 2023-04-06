using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenAndOddSum(Math.Abs(int.Parse(Console.ReadLine())));
        }

        static void EvenAndOddSum(int number)
        {
            int oddSum = 0;
            int evenSum = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }

                number /= 10;
            }
            Console.WriteLine(oddSum * evenSum);
        }
    }
}
