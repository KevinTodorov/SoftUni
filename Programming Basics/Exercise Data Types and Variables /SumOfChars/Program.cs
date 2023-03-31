using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int letterParse = letter;

                sum += letterParse;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
