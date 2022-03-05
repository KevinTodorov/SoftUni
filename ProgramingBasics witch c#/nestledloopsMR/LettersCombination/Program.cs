using System;

namespace LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string fist = Console.ReadLine();
            char a = char.Parse(fist);
            string second = Console.ReadLine();
            char b = char.Parse(second);
            string third = Console.ReadLine();
            char c = char.Parse(third);

            int n1 = (int)Convert.ToChar(a);
            int n2 = (int)Convert.ToChar(b);
            int n3 = (int)Convert.ToChar(c);
            int count = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    for (int k = n1; k <= n2; k++)
                    {
                        char one = Convert.ToChar(i);
                        char two = Convert.ToChar(j);
                        char three = Convert.ToChar(k);

                        if (one != c && two != c && three != c)
                        {
                         
                            count++;
                            Console.Write($"{one}{two}{three} ");
                        }
                    }
                }
            }
                            Console.Write($"{count}");
           
        }
    }
}