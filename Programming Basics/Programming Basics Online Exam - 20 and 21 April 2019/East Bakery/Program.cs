using System;

namespace East_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double yeast = double.Parse(Console.ReadLine());

            double sugarPrice = flourPrice - (flourPrice * 0.25);
            double eggsPrice = flourPrice + (flourPrice * 0.1);
            double yeastPrice = sugarPrice - (sugarPrice * 0.8);

            double flour = flourKg * flourPrice;
            double sugar = sugarPrice * sugarKg;
            double egg = eggsPrice * eggs;
            double yeastP = yeastPrice * yeast;
            double price = flour + sugar + egg + yeastP;
            Console.WriteLine($"{price:f2}");
        }
    }
}
