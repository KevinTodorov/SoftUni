using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_Integers
{
   public  class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            Box<int> box = new Box<int>(list);
            int[] indexes = Console.ReadLine().Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            box.SwapMethod(list, indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}
