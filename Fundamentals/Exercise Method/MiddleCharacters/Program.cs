﻿using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleCharacters(word);
        }

        static void MiddleCharacters(string word)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word[word.Length / 2]);
            }
            else
            {
                Console.Write(word[word.Length / 2 - 1]);
                Console.Write(word[word.Length / 2]);
            }
        }
    }
}
