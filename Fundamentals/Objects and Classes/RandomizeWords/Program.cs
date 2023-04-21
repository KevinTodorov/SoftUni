using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rdm = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomNum = rdm.Next(input.Length);
                string temp = input[i];
                input[i] = input[randomNum];
                input[randomNum] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
