using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int allSteps = 0;

            while(allSteps <= 10000)
            {
                string input = Console.ReadLine();

                if(input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    allSteps += stepsLeft;
                    if(allSteps >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!\r\n{allSteps - 10000} steps over the goal!");
                    }else if(allSteps < 10000)
                    {
                        Console.WriteLine($"{10000 - allSteps} more steps to reach goal.");
                    }
                    return;
                }
                int steps = int.Parse(input);
                allSteps += steps;
               
            }
            Console.WriteLine($"Goal reached! Good job!\r\n{allSteps - 10000} steps over the goal!");
        }
    }
}
