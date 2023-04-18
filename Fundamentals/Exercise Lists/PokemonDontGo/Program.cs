using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            int index = int.Parse(Console.ReadLine());

            while (true)
            {               
                int removedElement = 0;              

                if (index < 0)
                {
                    integers[0] = integers[integers.Count - 1];
                    removedElement = integers[0];
                }
                else if (index > integers.Count - 1)
                {
                    integers[integers.Count - 1] = integers[0];
                    removedElement = integers[integers.Count - 1];
                }
                else
                {
                    removedElement = integers[index];
                    integers.RemoveAt(index);
                }

                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] <= removedElement)
                    {
                        integers[i] += removedElement;
                    }
                    else
                    {
                        integers[i] -= removedElement;
                    }
                }


                sum += removedElement;
                if (integers.Count == 0)
                {
                    break;
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
