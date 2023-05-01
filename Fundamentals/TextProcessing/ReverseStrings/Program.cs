﻿using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            while (word != "end")
            {
                string reversedWord = String.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                Console.WriteLine($"{word} = {reversedWord}");

                word = Console.ReadLine();
            }
        }
    }
}
