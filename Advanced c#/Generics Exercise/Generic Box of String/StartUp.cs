using System;

namespace Generic_Box_of_String
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                var box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}
