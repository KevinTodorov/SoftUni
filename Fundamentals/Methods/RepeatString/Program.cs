using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatingCycle(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        static void RepeatingCycle(string words, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(words);
            }
        }
    }
}
