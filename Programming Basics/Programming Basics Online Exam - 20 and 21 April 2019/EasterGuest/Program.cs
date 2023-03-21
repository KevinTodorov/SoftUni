using System;

namespace EasterGuest
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double breads = Math.Ceiling(guests / 3);
            double eggs = guests * 2;
            double easternBreadPrice = breads * 4;
            double eggsPrice = eggs * 0.45;
            double price = eggsPrice + easternBreadPrice;

            if (budget >= price)
            {
                Console.WriteLine($"Lyubo bought {breads} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {(budget - price):f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {(price - budget):f2} lv. more.");
            }
        }
    }
}
