using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[array.Length - 1 - i] + " ");
            }
        }
    }
}
