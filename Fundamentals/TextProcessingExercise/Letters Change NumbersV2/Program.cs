using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_NumbersV2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabetList = new List<char>();
            alphabetList.Add('0');
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (char c = 'A'; c <= 'Z'; ++c)
            {
                alphabetList.Add(c);
            }

            for (int i = 0; i < input.Length; i++)
            {
                string num = String.Empty;
                string word = input[i];
                char letter = ' ';
                double number = 0;
                int count = 0;
                double currentSum = 0;

                for (int b = 0; b < word.Length; b++)
                {
                    if (b == 0 || b == word.Length - 1)
                    {
                        letter = word[b];
                        count++;
                    }

                    if (char.IsDigit(word[b]))
                    {
                        num += word[b];
                    }

                    if (count == 1 && char.IsDigit(word[b]) && char.IsLetter(word[b + 1]))
                    {
                        number = int.Parse(num);

                        if (char.IsUpper(letter))
                        {
                            int divider = alphabetList.IndexOf(alphabetList.First(x => x == letter));
                            number /= divider;
                            currentSum += number;
                        }
                        else
                        {
                            letter = char.Parse(letter.ToString().ToUpper());
                            int divider = alphabetList.IndexOf(alphabetList.First(x => x == letter));
                            number *= divider;
                            currentSum += number;
                        }
                    }else if (count == 2)
                    {
                        if (char.IsUpper(letter))
                        {
                            int divider = alphabetList.IndexOf(alphabetList.First(x => x == letter));
                            currentSum -= divider;
                        }
                        else
                        {
                            letter = char.Parse(letter.ToString().ToUpper());
                            int divider = alphabetList.IndexOf(alphabetList.First(x => x == letter));
                            currentSum += divider;
                        }
                    }
                }

                sum += currentSum;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
