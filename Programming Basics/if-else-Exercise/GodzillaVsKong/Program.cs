using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double sum = 0;
            if(statists > 150)
            {
                double priceS = clothes * statists;
                priceS -= priceS * 0.1;
                 sum = priceS + decor;
                
            }else if (statists < 150)
            {
                double priceS = clothes * statists;
                sum = priceS + decor;
            }if (budget >= sum)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - sum):f2} leva left.");
            }
            else if (budget < sum)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - sum):f2} leva more.");
            }
        }
    }
}
