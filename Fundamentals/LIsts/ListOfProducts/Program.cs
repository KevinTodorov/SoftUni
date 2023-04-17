using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            SortedProducts(n, products);
        }

        static void SortedProducts(int n, List<string>  sorted)
        {

            for (int i = 0; i < n; i++)
            {
                string help = Console.ReadLine();
                sorted.Add(help);
            }
            sorted.Sort();          

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{sorted[i - 1]}");
            }
        }
    }
}
