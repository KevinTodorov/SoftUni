using System;
using System.Numerics;

namespace BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberInBits = Convert.ToString(number, 2);
            BigInteger numberInInteger = BigInteger.Parse(numberInBits);

            char n = ' ';

            for (int i = numberInBits.Length - 1; i > 0; i--)
            {
                n = numberInBits[i - 1];
            }

            Console.WriteLine(n);
        }
    }
}
