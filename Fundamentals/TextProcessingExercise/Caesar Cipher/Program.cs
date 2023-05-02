using System;
using System.Threading;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedWord = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {

                char letter = input[i];
                int position = letter;
                position += 3;
                char c = (char)position;
                encryptedWord += c;
                
            }

            Console.WriteLine(encryptedWord);
        }
    }
}
