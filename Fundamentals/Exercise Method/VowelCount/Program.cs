using System;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelCount(Console.ReadLine());
        }

        static void VowelCount(string word)
        {
            int vowelCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                   || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
