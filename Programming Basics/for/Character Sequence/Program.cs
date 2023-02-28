using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lenght = text.Length;
            for(int i = 0; i <= lenght - 1; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
