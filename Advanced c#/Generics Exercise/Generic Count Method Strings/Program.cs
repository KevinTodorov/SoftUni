using System;
using System.Collections.Generic;

namespace Generic_Count_Method_Strings
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

            string letters = Console.ReadLine();
            var box = new Box<string>(list);
            var count = box.CountOfGreaterElements(list, letters);
            Console.WriteLine(count);
        }
    }
}
