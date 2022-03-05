using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            double neededCals = calories - (calories * 0.5);
            double allMins = minutes * walks;
            double allCals = allMins * 5;

            if (allCals >= neededCals)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {allCals}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {allCals}.");
            }
        }
    }
}
