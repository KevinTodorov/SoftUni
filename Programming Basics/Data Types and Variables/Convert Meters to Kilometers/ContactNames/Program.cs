using System;

namespace ContactNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string SecondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string result = firstName + delimeter + SecondName;

            Console.WriteLine(result);
        }
    }
}
