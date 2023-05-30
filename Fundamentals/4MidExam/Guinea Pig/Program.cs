using System;

namespace Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {

            double foodKg = double.Parse(Console.ReadLine());
            double hayKg = double.Parse(Console.ReadLine());
            double coverKg = double.Parse(Console.ReadLine());
            double guineaPigKgs = double.Parse(Console.ReadLine());

            double foodInGrams = foodKg * 1000;
            double hayInGrams = hayKg * 1000;
            double coverInGrams = coverKg * 1000;
            double gunieaPigInGrams = guineaPigKgs * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= 300;
                if (i % 2 == 0)
                {
                    hayInGrams -= foodInGrams * 0.05;
                }

                if (i % 3 == 0)
                {
                    coverInGrams -= (1.0 / 3.0) * gunieaPigInGrams;
                }

                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            double leftFood = foodInGrams / 1000;
            double leftHay = hayInGrams / 1000;
            double leftCover = coverInGrams / 1000;

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {leftFood:f2}, Hay: {leftHay:f2}, " +
                              $"Cover: {leftCover:f2}.");
        }
    }
}
