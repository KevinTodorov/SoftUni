using System;

namespace Generic_Box_of_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}
