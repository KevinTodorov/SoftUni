using System;
using System.Linq;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int strength = 0;
                    if (char.IsDigit(input[i + 1]))
                    {
                        strength = int.Parse(input[i + 1].ToString());
                    }
                    for (int j = 1; j <= strength; j++)
                    {
                        if (input[input.IndexOf('>') + j] == '>')
                        {
                            if (Char.IsDigit(input[input.IndexOf('>') +j + 1]))
                            {
                                strength += int.Parse(input[j + i + 1].ToString());
                            }
                        }
                        else
                        {
                            input = input.Remove(input.IndexOf('>') + j, 1);
                        }

                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
