using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int poinstAfterFinishing = startingPoints;
            int wins = 0;
            
            for(int i = 1; i <= tournaments; i++)
            {
                string type = Console.ReadLine();
                if(type == "W")
                {
                    poinstAfterFinishing += 2000;
                    wins++;
                }else if(type == "F")
                {
                    poinstAfterFinishing += 1200;
                }else if(type == "SF")
                {
                    poinstAfterFinishing += 720;
                }
            }
            double average = (poinstAfterFinishing - startingPoints) / tournaments;
            double percents = ((double)wins / tournaments) * 100;
            Console.WriteLine($"Final points: {poinstAfterFinishing}");
            Console.WriteLine($"Average points: {Math.Ceiling(average)}");
            Console.WriteLine($"{percents:f2}%");
        }
    }
}
