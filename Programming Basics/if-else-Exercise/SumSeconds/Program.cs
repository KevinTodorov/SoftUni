using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            
            int allTime = firstTime + secondTime + thirdTime;

            int minutes = allTime / 60;
            int seconds = allTime % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
