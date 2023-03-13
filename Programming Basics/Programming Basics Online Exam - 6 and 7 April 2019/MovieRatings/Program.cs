using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int films = int.Parse(Console.ReadLine());
            //string filmName = Console.ReadLine();
            //double filmRating = double.Parse(Console.ReadLine());

            double allRatings = 0;
            double highestRating = 0;
            double lowestRating = int.MaxValue;

            string highSave = "";
            string lowestSave = "";

            for (int i = 1; i <= films; i++)
            {
               string filmName = Console.ReadLine();
               double filmRating = double.Parse(Console.ReadLine());
                allRatings += filmRating;
                if (filmRating > highestRating)
                {
                    highSave = $"{filmName} is with highest rating: {filmRating:f1}";
                    highestRating = filmRating;
                }
                if (filmRating < lowestRating)
                {
                    lowestRating = filmRating;
                }
                if (filmRating <= lowestRating)
                {
                    lowestRating = filmRating;
                    lowestSave = $"{filmName} is with lowest rating: {filmRating:f1}";
                }
            }
            Console.WriteLine(highSave);
            Console.WriteLine(lowestSave);
            Console.WriteLine($"Average rating: {allRatings / films:f1}");

        }
    }
}
