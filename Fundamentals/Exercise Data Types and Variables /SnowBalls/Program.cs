using System;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            byte snowballs = byte.Parse(Console.ReadLine());

            double maxValue = double.MinValue;

            double snowballValue = 0;

            short bestSnow = 0;
            short bestTime = 0;
            byte bestQuality = 0;

            for (int i = 1; i <= snowballs; i++)
            {

                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuality})");
        }
    }
}
