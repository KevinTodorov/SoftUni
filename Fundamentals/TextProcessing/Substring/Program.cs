using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string wordToBeRemoved = Console.ReadLine();
            string word = Console.ReadLine();
            int index = word.IndexOf(wordToBeRemoved);

            while (index >= 0)
            {
               word = word.Remove(index, wordToBeRemoved.Length);
               index = word.IndexOf(wordToBeRemoved);
            }

            Console.WriteLine(word);
        }
    }
}
