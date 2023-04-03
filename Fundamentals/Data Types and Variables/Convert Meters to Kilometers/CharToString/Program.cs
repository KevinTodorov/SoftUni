using System;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string result = first.ToString() + second.ToString() + third.ToString();

            Console.WriteLine(result);
        }
    }
}
