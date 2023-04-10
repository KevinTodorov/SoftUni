using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            charactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }

        static void charactersInRange(char c, char b)
        {
            int count = 0;
            for (int i = (int)c + 1; i <= (int)b - 1; i++)
            {
                char help = (char)i;
                Console.Write(help + " ");
                count++;
            }
            if(count == 0)
            {
                for (int i = (int)b + 1; i <= (int)c - 1; i++)
                {
                    char help = (char)i;
                    Console.Write(help + " ");
                }
            }
        }
    }
}
