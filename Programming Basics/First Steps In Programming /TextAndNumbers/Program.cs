﻿using System;

namespace TextAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string Town = Console.ReadLine();
            Console.WriteLine("You are " + FirstName + " " + LastName + "," + " a " + age + " - years old person from " + Town + "." );
        }
    }
}
