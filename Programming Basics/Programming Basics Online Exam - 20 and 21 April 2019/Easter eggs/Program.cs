using System;

namespace Easter_eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());
            string colour = Console.ReadLine();
            int maxNum = int.MinValue;
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int allEggs = 0;

            for (int i = 1; i <= paintedEggs; i++)
            {

                while (allEggs < i)
                {


                    if (colour == "red")
                    {
                        redEggs += 1;
                        allEggs += 1;
                    }
                    else if (colour == "orange")
                    {
                        orangeEggs += 1;
                        allEggs += 1;
                    }
                    else if (colour == "blue")
                    {
                        blueEggs += 1;
                        allEggs += 1;
                    }
                    else if (colour == "green")
                    {
                        greenEggs += 1;
                        allEggs += 1;
                    }
                  
                  colour = Console.ReadLine();
                }

            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            if (redEggs > maxNum && orangeEggs < redEggs && blueEggs < redEggs && greenEggs < redEggs)
            {
                maxNum = redEggs;
                Console.WriteLine($"Max eggs: {redEggs} -> red");
            }else if (orangeEggs > maxNum && redEggs < orangeEggs && blueEggs < orangeEggs && greenEggs < orangeEggs)
            {
                maxNum = orangeEggs;
                Console.WriteLine($"Max eggs: {orangeEggs} -> orange");
            }
            else if (blueEggs > maxNum && redEggs < blueEggs && orangeEggs < blueEggs && greenEggs < blueEggs)
            {
                maxNum = blueEggs;
                Console.WriteLine($"Max eggs: {blueEggs} -> blue");
            }
            else if (greenEggs > maxNum && redEggs < greenEggs && blueEggs < greenEggs && orangeEggs < greenEggs)
            {
                maxNum = greenEggs;
                Console.WriteLine($"Max eggs: {greenEggs} -> green");
            }
        }
    }
}
