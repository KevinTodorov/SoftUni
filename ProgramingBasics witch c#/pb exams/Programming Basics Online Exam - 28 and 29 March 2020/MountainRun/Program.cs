using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());
            double addedSeconds = 0;

            if (meters >= 50)
            {
                double help = Math.Floor(meters / 50);
                addedSeconds = help * 30;
            }

            double seconds = meters * timeInSecondsForOneMeter + addedSeconds;

            if (seconds >= record)
            {
                Console.WriteLine($"No! He was {seconds - record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {seconds:f2} seconds.");
            }
        }
    }
}
