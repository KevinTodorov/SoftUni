using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValue = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (typeOfValue)
            {
                case "int":
                   int sum = getMax(int.Parse(firstValue), int.Parse(secondValue));
                    Console.WriteLine(sum);
                    break;
                case "char":
                   char help = getMax(char.Parse(firstValue), char.Parse(secondValue));
                    Console.WriteLine(help);
                    break;
                case "string":
                    string result = getMax(firstValue, secondValue);
                    Console.WriteLine(result);
                    break;
            }

        }

        static int getMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char getMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string getMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                 return b;
            }
        }
    }
}
