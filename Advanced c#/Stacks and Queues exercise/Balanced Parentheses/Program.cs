using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            var firstTypeOfParentheses = new List<char> { '(', ')' };
            var secondTypeOfParentheses = new List<char> { '{', '}' };
            var thirdTypeOfParentheses = new List<char> { '[', ']' };

            var openingBracket = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[' || input[i] == ' ')
                {
                    openingBracket.Push(input[i]);
                }
                else if (input[i] == firstTypeOfParentheses[1] && openingBracket.Peek() == firstTypeOfParentheses[0])
                {
                    openingBracket.Pop();
                }
                else if (input[i] == secondTypeOfParentheses[1] && openingBracket.Peek() == secondTypeOfParentheses[0])
                {
                    openingBracket.Pop();
                }
                else if (input[i] == thirdTypeOfParentheses[1] && openingBracket.Peek() == thirdTypeOfParentheses[0])
                {
                    openingBracket.Pop();
                }
                else if (input[i] == ' ' && openingBracket.Peek() == ' ')
                {
                    openingBracket.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (!openingBracket.Any())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}