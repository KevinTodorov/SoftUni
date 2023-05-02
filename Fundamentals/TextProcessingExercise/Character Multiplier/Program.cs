using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int minLenght = Math.Min(input[0].Length, input[1].Length);
            int sum = 0;
            int biggerLenght = 0;
            string one = input[0];
            string two = input[1];
            string biggerString = String.Empty;

            for (int i = 0; i < minLenght; i++)
            {
                sum += one[i] * two[i];
            }

            if (input[0].Length > input[1].Length)
            {
                biggerLenght = input[0].Length;
                biggerString = input[0];
            }
            else
            {
                biggerLenght = input[1].Length;
                biggerString = input[1];
            }

            for (int i = minLenght; i < biggerLenght; i++)
            {
                sum += biggerString[i];
            }

            Console.WriteLine(sum);

        }
    }
}
