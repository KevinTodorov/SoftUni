using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if(type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:f3}");
            }else if(type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB:f3}");
            }else if(type == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{r * r * Math.PI:f3}");
            }else if(type == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB / 2:f3}");
            }
        }
    }
}
