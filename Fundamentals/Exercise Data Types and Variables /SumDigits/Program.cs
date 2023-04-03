using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string help = n1.ToString();
            int length = help.Length;

            int sum = 0;

            for (int i = 1; i <= length; i++)
            {
                sum += n1 % 10;
                n1 /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
