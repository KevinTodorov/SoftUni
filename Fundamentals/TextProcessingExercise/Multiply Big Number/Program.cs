﻿using System;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder stringFinalProduct = new StringBuilder();
            int reminder = 0;

            if (input == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());
                int product = currentDigit * multiplier + reminder;
                int result = product % 10;
                reminder = product;
                stringFinalProduct.Insert(0, result);
            }

            if (reminder == 0)
            {
                stringFinalProduct.Insert(0, reminder.ToString());
            }

            Console.WriteLine(stringFinalProduct);
        }
    }
}
