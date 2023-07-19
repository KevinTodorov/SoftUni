using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printAction = n => Console.WriteLine(n);

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var name in names)
            {
                printAction(name);
            }
        }
    }
}
