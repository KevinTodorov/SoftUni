﻿using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
                       
           string command = Console.ReadLine();

            while (command != "END")
            {               
                bool palindromeOrNot = Palindrome(command);
                Console.WriteLine(palindromeOrNot);
                command = Console.ReadLine();             
            }
        }

        static bool Palindrome(string command)
        {
            int number = int.Parse(command);
         
            if (number >= 0 && number <= 9)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < command.Length / 2; i++)
                {
                    if (command[i] == command[command.Length - 1])
                    {
                        return true;
                    }
                    
                }
                return false;
            }
                
           
        }
    }
}
