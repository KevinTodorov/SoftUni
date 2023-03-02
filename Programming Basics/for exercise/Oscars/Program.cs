using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());
            double sum = 0 + academyPoints;

            for (int i = 1; i <= judges; i++)
            {
                string judgeName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                int point = judgeName.Length;
                double judgesPoints = (point * points) / 2;
                sum += judgesPoints;

                if (sum >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {sum:f1}!");
                    return;
                }

            }
            
            
                Console.WriteLine($"Sorry, {name} you need {(1250.5 - sum):f1} more!");
            
        }
    }
}
