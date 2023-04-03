using System;

namespace PrintPartOfTheAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                char symbol = (char)i;

                Console.Write(symbol + " ");
            }
        }
    }
}
