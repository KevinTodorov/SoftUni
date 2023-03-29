using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int britishPounds = int.Parse(Console.ReadLine());
            decimal dollars = britishPounds * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
