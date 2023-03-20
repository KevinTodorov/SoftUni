using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteBalls = 0;
            int otherColoursCounter = 0;
            int blackBallsCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        redCounter++;
                        totalPoints += 5;
                        break;
                    case "orange":
                        orangeCounter++;
                        totalPoints += 10;
                        break;
                    case "yellow":
                        yellowCounter++;
                        totalPoints += 15;
                        break;
                    case "white":
                        whiteBalls++;
                        totalPoints += 20;
                        break;
                    case "black":
                        blackBallsCounter++;
                        totalPoints = Math.Floor(totalPoints / 2);
                        break;
                    default:
                        otherColoursCounter++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {redCounter}");
            Console.WriteLine($"Orange balls: {orangeCounter}");
            Console.WriteLine($"Yellow balls: {yellowCounter}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherColoursCounter}");
            Console.WriteLine($"Divides from black balls: {blackBallsCounter}");
        }
    }
}
