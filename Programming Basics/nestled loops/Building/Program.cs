using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
           int rows = int.Parse(Console.ReadLine());

            for (int floor = floors; floor <= floors; floor--)
            {
                if (floor < 1)
                {
                    break;
                }
                for (int row = 0; row < rows; row++)
                {
                    if(floor == floors)
                    {
                        Console.Write($"L{floor}{row} ");
                        
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{row} ");
                    }else
                    {
                        Console.Write($"A{floor}{row} ");
                    }
                    
                }
            Console.WriteLine();
            }
        }
    }
}
