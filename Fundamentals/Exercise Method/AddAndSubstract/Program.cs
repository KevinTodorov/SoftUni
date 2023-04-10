using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            int finalNum = Substract(sum, int.Parse(Console.ReadLine()));
            Console.WriteLine(finalNum);
        }

        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int Substract(int sum, int c)
        {
            return sum - c;
        }
    }
}
