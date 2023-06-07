using System;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex =
                new Regex(@"(\||\#)(?<name>[a-zA-Z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]+)\1");

            MatchCollection mathingFoods = regex.Matches(text);

            int calories = 0;

            foreach (Match food in mathingFoods)
            {
                int caloriesOfCurrentFood = int.Parse(food.Groups["calories"].Value);

                if (caloriesOfCurrentFood <= 10000 && caloriesOfCurrentFood >= 0)
                {
                    calories += caloriesOfCurrentFood;
                }
            }

            int days = calories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match food in mathingFoods)
            {
                Console.WriteLine($"Item: {food.Groups["name"].Value}, Best before: {food.Groups["date"].Value}, Nutrition: {food.Groups["calories"].Value}");
            }
        }
    }
}
