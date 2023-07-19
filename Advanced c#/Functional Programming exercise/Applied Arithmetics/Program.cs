using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                    {
                       numbers = numbers.Select(x => x + 1).ToList();
                    }break;
                    case "multiply":
                    {
                      numbers = numbers.Select(x => x * 2).ToList();
                    }
                        break;
                    case "subtract":
                    {
                       numbers = numbers.Select(x => x - 1).ToList();
                    }
                        break;
                    case "print":
                    {
                        Console.WriteLine($"{string.Join(" ", numbers)}");
                    }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
