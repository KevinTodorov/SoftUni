using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i <= 97 + n - 1; i++)
            {
                for (int b = 97; b <= 97 + n - 1; b++)
                {
                    for (int c = 97; c <= 97 + n - 1; c++)
                    {
                        Console.WriteLine((char)i + "" + (char)b + "" + (char)c);
                    }
                }
            }
        }
    }
}
