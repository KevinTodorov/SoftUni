using System;
using System.Threading.Channels;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> namePat = n => Console.WriteLine($"Sir {n}");
            foreach (var name in names)
            {
                namePat(name);
            }
        }
    }
}
