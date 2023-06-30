using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 1; i <= lines; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
