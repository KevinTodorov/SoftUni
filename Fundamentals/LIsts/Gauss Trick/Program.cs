using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            Gauss(numbers);
        }
            
        static void Gauss(List<double> list)
        {

            if (list.Count/2 % 2 == 0)
            {
                for (int i = 0; i <= list.Count / 2; i++)
                {
                    if (i == 0)
                    {
                        list[i] = list[i] + list[list.Count - 1 - i];
                        list.RemoveAt(list.Count - 1 - i);
                        continue;
                    }

                    list[i] = list[i] + list[list.Count - i];
                    list.RemoveAt(list.Count - i);
                    Console.WriteLine(string.Join(" ", list));
                    return;
                }
            }

            for (int i = 0; i < list.Count/2; i++)
            {
                if (i == 0)
                {
                  list[i] = list[i] + list[list.Count - 1 - i];
                  list.RemoveAt(list.Count - 1 - i);
                    continue;
                }

                list[i] = list[i] + list[list.Count - i];
                list.RemoveAt(list.Count - i);

            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
