﻿using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > sum)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
                
            }
            Console.WriteLine(sum);
        }
    }
}
