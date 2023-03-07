using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int pieces = width * lenght;
            int untouchedPieces = pieces;
            string input = Console.ReadLine();
            
            while(input != "STOP")
            {

                if(pieces < int.Parse(input))
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces - int.Parse(input))} pieces more.");
                    return;
                }
                pieces -= int.Parse(input);
                input = Console.ReadLine();
            }
            if(untouchedPieces - pieces >= 0)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(untouchedPieces - pieces)} pieces more.");
            }
        }
    }
}
