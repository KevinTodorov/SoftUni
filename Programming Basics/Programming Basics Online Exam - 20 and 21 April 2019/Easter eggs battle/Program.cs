using System;

namespace Easter_eggs_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayersEggs = int.Parse(Console.ReadLine());
            int secondPlayersEggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while(command != "End of battle")
            {
                if(command == "one")
                {
                    secondPlayersEggs -= 1;
                }
                else if(command == "two")
                {
                    firstPlayersEggs -= 1;
                }
                if (firstPlayersEggs <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayersEggs} eggs left.");
                    return;
                }else if(secondPlayersEggs <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayersEggs} eggs left.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Player one has {firstPlayersEggs} eggs left.\r\nPlayer two has {secondPlayersEggs} eggs left.");
        }
    }
}
