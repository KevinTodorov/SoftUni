using System;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker(int.Parse(Console.ReadLine()));
        }

        static void Checker(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n > 0 )
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else
            {
                Console.WriteLine($"The number 0 is zero");
            }
        }
    }
}
