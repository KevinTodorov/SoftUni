using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double biscuits = 0;
            double daysCounter = 1;
            double dogEatenFood = 0;
            double catEatenFood = 0;
            double foodPercentage = 0;

            for (int i = 1; i <= days; i++)
            {
                int eatenFoodByDog = int.Parse(Console.ReadLine());
                int eatenFoodByCat = int.Parse(Console.ReadLine());

                dogEatenFood += eatenFoodByDog;
                catEatenFood += eatenFoodByCat;

                if (daysCounter == 3)
                {
                    biscuits += (eatenFoodByCat + eatenFoodByDog) * 0.1;
                }

                if (daysCounter >= 3)
                {
                    daysCounter = 0;
                }
                daysCounter++;
            }
            double eatenFood = catEatenFood + dogEatenFood;
            double eatenFoodInPercentage = (eatenFood / food) * 100;
            double dogFoodInPercentage = (dogEatenFood / eatenFood) * 100;
            double catFoodInPercentage = (catEatenFood / eatenFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{eatenFoodInPercentage:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFoodInPercentage:f2}% eaten from the dog.");
            Console.WriteLine($"{catFoodInPercentage:f2}% eaten from the cat.");
        }
    }
}
