using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            double raspPrice = strawberriesPrice / 2;
            double raspberriesSum = raspPrice * raspberries;

            double orangesPrice = raspPrice - (0.4 * raspPrice);
            double orangesSum = oranges * orangesPrice;

            double bananasPrice = raspPrice - (raspPrice * 0.8);
            double bananasSum = bananasPrice * bananas;

            double straberriesSum = strawberries * strawberriesPrice;

            double sum = raspberriesSum + orangesSum + bananasSum + straberriesSum;

            Console.WriteLine($"{sum:f2}");

        }
    }
}
