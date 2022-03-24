using System;
using System.Linq;

namespace WordFIlter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
