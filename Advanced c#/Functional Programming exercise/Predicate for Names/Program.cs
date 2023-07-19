using System;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfString = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> predicate = name =>
            {
                if (name.Length <= lenghtOfString)
                {
                    return true;
                }
                else return false;
            };

            foreach (var name in names)
            {
                if (predicate(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
