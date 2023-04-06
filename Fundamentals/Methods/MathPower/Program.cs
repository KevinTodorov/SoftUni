using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
           double result = NumberWithPow(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }

        static double NumberWithPow(double a, int b)
        {

            return Math.Pow(a, b);
        }
    }
}
