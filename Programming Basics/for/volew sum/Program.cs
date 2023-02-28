using System;

namespace volew_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            int lenght = letter.Length;
            int sum = 0;
            for(int i = 0; i <= lenght - 1; i++)
            {
                char Lt = letter[i];
                switch (Lt)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                        
                }

            }
                Console.WriteLine(sum);
        }
    }
}
