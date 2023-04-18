﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Append_Arrays
{
    class Program
    {

        private static readonly Regex regex = new Regex(@"^\d+$");
        static void Main(string[] args)
        {         

            List<string> numbersAsStrings = Console.ReadLine()
                                .Split('|')
                                .Reverse()
                                .ToList();
            List<int> numbers = new List<int>();

            foreach(var str in numbersAsStrings)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }
            Console.WriteLine(string.Join(" ", numbers));            
        }
    }
}
