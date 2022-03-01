using System;

namespace Oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int graders = int.Parse(Console.ReadLine());
            double pointSum = 0;

            for(int i = 1; i <= graders; i++)
            {
                string Name = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());
                int lenght = Name.Length;
                pointSum += ((lenght * pointsFromJudge) / 2);
            }
            if (pointSum + points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {(pointSum + points):f1}!");
            }
            else Console.WriteLine($"Sorry, {name} you need {(1250.5 - (pointSum + points)):f1} more!");
        }
    }
}
