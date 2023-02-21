using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());

            double eat = 0.125 * rest;
            double peace = 0.25 * rest;
            double freeTime = rest - (eat + peace);

            if(freeTime >= episode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(freeTime - episode)} minutes free time.");
            }
            else Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episode - freeTime)} more minutes.");
        }
    }
}
