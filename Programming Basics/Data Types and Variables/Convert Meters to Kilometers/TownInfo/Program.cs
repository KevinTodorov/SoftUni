﻿using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            long km = long.Parse(Console.ReadLine());

            Console.WriteLine($"Town {name} has population of {population} and area {km} square km.");
        }
    }
}
