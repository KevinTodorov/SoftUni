using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;


            while (flag != true)
            {
                int n = int.Parse(Console.ReadLine());

                if (Math.Abs(n) % 2 == 0)
                {
                    Console.WriteLine($"The number is: {n}");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
