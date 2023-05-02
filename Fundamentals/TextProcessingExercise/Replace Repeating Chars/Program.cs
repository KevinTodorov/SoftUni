using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousLetter = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                char letterAtTheMoment = input[i];

                if (letterAtTheMoment != previousLetter)
                {
                    previousLetter = input[i];
                    Console.Write(letterAtTheMoment);
                }
            }

        }
    }
}
