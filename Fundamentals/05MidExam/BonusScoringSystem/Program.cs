using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int aditionalBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int mostParticipatedLectures = 0;
            int help = 5 + aditionalBonus;

            for (int i = 1; i <= students; i++)
            {
                int participatedLectures = int.Parse(Console.ReadLine());
                double totalBonus = ((double)participatedLectures / (double)lectures) * help;

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    mostParticipatedLectures = participatedLectures;
                }
            }

            Console.WriteLine("Max Bonus: {0}.", Math.Ceiling(maxBonus));
            Console.WriteLine($"The student has attended {mostParticipatedLectures} lectures.");
        }
    }
}
