using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double YearlyPercent = double.Parse(Console.ReadLine());

            double sum = deposit + time * ((deposit * (YearlyPercent / 100) / 12));

            Console.WriteLine(sum);
        }
    }
}
