using System;

namespace EasternCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakes = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string grades = Console.ReadLine();
            string winner = "";
            int sum = 0;

            for (int i = 1; i <= cakes; i++)
            {
                int currSum = sum;
                sum = 0;
                while (grades != "Stop")
                {
                    int grade = int.Parse(grades);
                    sum += grade;
                    grades = Console.ReadLine();
                    
                }
                Console.WriteLine($"{name} has {sum} points.");
                if (sum > currSum) 
                {
                    Console.WriteLine($"{name} is the new number 1!");
                    winner = $"{name} won competition with {sum} points!";
                }
                name = Console.ReadLine();
                grades = Console.ReadLine();
            }
            Console.WriteLine(winner);
        }
    }
}
