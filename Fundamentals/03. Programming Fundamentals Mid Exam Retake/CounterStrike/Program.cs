using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int count = 0;
            int winningCount = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (initialEnergy >= distance)
                {
                    initialEnergy -= distance;
                    winningCount++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} " +
                        $"won battles and {initialEnergy} energy");
                    return;
                }

                if (winningCount == 3)
                {
                    initialEnergy += winningCount;
                    winningCount = 0;
                }
                  
                count++;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {count}. Energy left: {initialEnergy}");
        }
    }
}
