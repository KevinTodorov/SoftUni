using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabetList = new List<char>();
            alphabetList.Add('0');
            string[] input = Console.ReadLine().Split();
            double sum = 0;

            for (char c = 'A'; c <= 'Z'; ++c)
            {
                alphabetList.Add(c);
            }

            for (int i = 0; i < input.Length; i++)
            {
                char letter = ' ';
                string word = input[i];
                string number = string.Empty;
                double num = 0;
                int count = 0;
                double currentSum = 0;

                for (int j = 0; j < word.Length; j++)
                {

                    if (Char.IsLetter(word[j]))
                    {
                        letter = word[j];
                        count++;
                    }

                    if (count == 2)
                    {
                        if (char.IsUpper(letter))
                        {
                            int index = alphabetList.IndexOf(alphabetList.First(x => x == letter));
                            num -= index;
                        }
                        else
                        {
                            letter = char.Parse(letter.ToString().ToUpper());
                            int index = alphabetList.IndexOf(alphabetList.First(x => x == letter));
                            num += index;
                        }

                        currentSum += num; 
                        break;
                    }

                    if (char.IsDigit(word[j]))
                    {
                        number += word[j].ToString();
                    }

                    if (char.IsDigit(word[j]) && char.IsLetter(word[j + 1]))
                    {
                        num = int.Parse(number);
                        if (count == 1)
                        {
                            if (char.IsUpper(letter))
                            {
                                int index = alphabetList.IndexOf(alphabetList.First(x         => x == letter));
                                num /= index;
                            }
                            else
                            {
                                letter = char.Parse(letter.ToString().ToUpper());
                                int index = alphabetList.IndexOf(alphabetList.First(x         => x == letter));
                                num *= index;
                            }

                            currentSum += num;
                        }
                    }
                }
            }
                Console.WriteLine($"{sum:f2}");
        }
    }
}
