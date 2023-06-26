using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < 8; i++)
            {
                string name = Console.ReadLine();
                if (!names.Contains(name))
                {
                    names.Add(name);
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
