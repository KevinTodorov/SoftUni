using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int currGoals = 0;
            string save = "";

            while(command != "END")
            {
                string player = command;
                int goals = int.Parse(Console.ReadLine());
                if(goals >= 10)
                {
                    Console.WriteLine($"{player} is the best player!");
                    Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                    return;
                }
                if (goals > currGoals && goals >= 3)
                {
                    save = $"{player} is the best player!\r\nHe has scored {goals} goals and made a hat-trick !!!";

                }
                else if (goals > currGoals && goals < 3)
                {
                    save = $"{player} is the best player!\r\nHe has scored {goals} goals.";
                }
                 currGoals = goals;
                command = Console.ReadLine();
            }
            Console.WriteLine(save);
        }
    }
}
