using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (number > 7 || number <= 0)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            Console.WriteLine(days[number - 1]);
        }
    }
}
