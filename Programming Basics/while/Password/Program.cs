using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string password = "";

            while(password != pass)
            {
               password = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}");
        }
    }
}
