using System;
using System.Collections.Generic;
using System.Linq;

namespace MUonline
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string[] commandInArray = command.Split("|").ToArray();
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 1;

            for (int i = 0; i < commandInArray.Length; i++)
            {
                string[] help = commandInArray[i].Split(" ").ToArray();
                string word = help[0];
                int number = int.Parse(help[1]);               

                switch (word)
                {
                    case "potion":
                        if (health < 100 && health + number <= 100)
                        {
                            health += number;
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            int healthCounter = 0;
                            while (true)
                            {
                                if (health == 100)
                                {
                                    break;
                                }
                                health++;
                                healthCounter++;
                            }
                            Console.WriteLine($"You healed for {healthCounter} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;
                    case "chest":
                        Console.WriteLine($"You found {number} bitcoins.");
                        bitcoins += number;
                        break;
                    default:
                        if (health - number > 0)
                        {
                            Console.WriteLine($"You slayed {word}.");
                            health -= number;
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {word}.");
                            Console.WriteLine($"Best room: {bestRoom}");
                            return;
                        }
                        break;
                }
                        bestRoom++;
            }
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
        }
    }
}
