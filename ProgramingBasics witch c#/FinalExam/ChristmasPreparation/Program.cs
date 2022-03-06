using System;

namespace ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ROLL = 5.80;
            const double MATERIAL = 7.20;
            const double GLUE = 1.20;

            int rolls = int.Parse(Console.ReadLine());
            int rollsMaterial = int.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double rollsPrice = rolls * ROLL;
            double rollsMaterialPrice = rollsMaterial * MATERIAL;
            double gluePrice = glueLiters * GLUE;
            double all = rollsPrice + rollsMaterialPrice + gluePrice;

            double discountPrice = all - (all * (percentDiscount / 100));

            Console.WriteLine($"{discountPrice:f3}");
        }
    }
}
