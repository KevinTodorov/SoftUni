using System;

namespace DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (Char.IsDigit(c))
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (Char.IsLetter(c))
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (!Char.IsLetter(c) && !Char.IsDigit(c))
                {
                    Console.Write(c);
                }
            }
        }
    }
}
