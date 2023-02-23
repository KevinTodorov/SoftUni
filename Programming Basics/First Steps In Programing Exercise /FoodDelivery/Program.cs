using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int ChickenMenus = int.Parse(Console.ReadLine());
            int FishMenus = int.Parse(Console.ReadLine());
            int VegeterianMenus = int.Parse(Console.ReadLine());
            double price = (ChickenMenus * 10.35) + (FishMenus * 12.40) + (VegeterianMenus * 8.15);
            double desert = price * 0.2;
            double FinalPrice = price + desert + 2.50;
            Console.WriteLine(FinalPrice);
        }
    }
}
