﻿using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            switch (type)
            {
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else Console.WriteLine("Master");
                    break;
                case "f":
                    if(age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else Console.WriteLine("Miss");
                    break;
            }
        }
    }
}
