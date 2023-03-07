using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width =int.Parse(Console.ReadLine());
            int lenght =int.Parse(Console.ReadLine());
            int hight =int.Parse(Console.ReadLine());
            int avaibleSpace =width * lenght * hight;
            int sum =0;
            string input =Console.ReadLine();

            while(input != "Done")
            {
                int space =int.Parse(input);
                sum +=space;
                if(avaibleSpace - sum < 0)
                {
                    Console.WriteLine($"No more free space! You need {sum - avaibleSpace} Cubic meters more.");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{avaibleSpace - sum} Cubic meters left.");
        }
    }
}
