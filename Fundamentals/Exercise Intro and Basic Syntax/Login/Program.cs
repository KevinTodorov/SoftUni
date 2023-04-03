using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string passsword = string.Join("", name.Reverse());

            for (int i = 1; i <= 4; i++)
            {
                string test = Console.ReadLine();

                if (test == passsword)
                {
                    Console.WriteLine($"User {name} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                if (i == 4)
                {
                    Console.WriteLine($"User {name} blocked!");
                    return;
                }

            }

        }
    }
}
