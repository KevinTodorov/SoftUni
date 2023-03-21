using System;

namespace Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sum = 0;

            while (command != "Close")
            {
                int addedEggs = int.Parse(Console.ReadLine());
                if(command == "Buy" && addedEggs <= eggs)
                {
                   eggs -= addedEggs;
                    sum += addedEggs;
                }else if(command == "Fill")
                {
                  eggs += addedEggs;                 
                }
                else
               
                {
                    Console.WriteLine($"Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {eggs}.");
                    return;
                }
               
                command = Console.ReadLine();
            }
            Console.WriteLine($"Store is closed!\r\n{sum} eggs sold.");
        }
    }
}
