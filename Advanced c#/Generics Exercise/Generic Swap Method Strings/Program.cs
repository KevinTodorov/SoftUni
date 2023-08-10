using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            Box<string> box = new Box<string>(list);
            int[] indexes = Console.ReadLine().Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            box.SwapMethod(list, indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}
