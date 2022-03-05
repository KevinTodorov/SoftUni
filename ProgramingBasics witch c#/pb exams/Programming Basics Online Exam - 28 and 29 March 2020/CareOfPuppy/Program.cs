using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtFoodKg = int.Parse(Console.ReadLine());
            int boughtFoodInGrams = boughtFoodKg * 1000;
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "Adopted")
            {
                int gramsEatenBeforeAdoption = int.Parse(command);
                sum += gramsEatenBeforeAdoption;

                command = Console.ReadLine();
            }

            if (sum > boughtFoodInGrams)
            {
                Console.WriteLine($"Food is not enough. You need {sum - boughtFoodInGrams} grams more.");
            }else
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughtFoodInGrams - sum} grams.");
            }
        }
    }
}
