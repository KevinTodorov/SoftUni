using System;

namespace FactorielDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            double result1 = FactorielDivision(n1);
            double result2 = FactorielDivision(n2);
            Console.WriteLine($"{result1 / result2:f2}");
        }

         static int FactorielDivision(int n)
        {
            int result = 1;
            while (n != 1)
            {
                result *= n;
                n--;
            }
            return result;
        }
    }
}
