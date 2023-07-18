using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = s => Char.IsUpper(s[0]);
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => predicate(x)).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
