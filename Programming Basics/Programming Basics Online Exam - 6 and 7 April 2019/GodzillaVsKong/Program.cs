using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double statistsPrice = double.Parse(Console.ReadLine());

            double decorPrice = filmBudget * 0.1;
            double statistFinalPrice = statists * statistsPrice;

            if (statists > 150)
            {
                statistFinalPrice -= statistFinalPrice * 0.1;
            }

            double finalSum = decorPrice + statistFinalPrice;

            if (finalSum <= filmBudget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - finalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!\r\nWingard needs {(finalSum - filmBudget):f2} leva more.");
            }
        }
    }
}
