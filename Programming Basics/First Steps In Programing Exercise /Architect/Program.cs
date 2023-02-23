using System;

namespace Architect
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int Projects = int.Parse(Console.ReadLine());
            int Hours = Projects * 3;
            Console.WriteLine("The architect " + name + " will need " + Hours + " hours to complete " + Projects + " project/s.");
        }
    }
}
