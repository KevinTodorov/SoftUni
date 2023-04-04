using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            for (int i = 0; i < secondLine.Length; i++)
            {
                for (int b = 0; b < firstLine.Length; b++)
                {
                    if (secondLine[i] == firstLine[b])
                    {
                        Console.Write(secondLine[i] + " ");
                    }
                }
            }

            //foreach (var letter in firstLine)
            //{
            //    Console.WriteLine(letter);
            //}
        }
    }
}
