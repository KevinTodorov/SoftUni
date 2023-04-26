using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char oneOrZero = char.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            int count = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (oneOrZero == binary[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
