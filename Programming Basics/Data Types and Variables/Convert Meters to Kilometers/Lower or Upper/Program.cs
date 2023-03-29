using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if ((int)letter >= 65 && (int)letter <= 90  )
            {
                Console.WriteLine("upper-case");
            }
            else Console.WriteLine("lower-case");
        }
    }
}
