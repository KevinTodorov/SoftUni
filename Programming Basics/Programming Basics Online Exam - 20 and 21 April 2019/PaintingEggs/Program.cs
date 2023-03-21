using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string colour = Console.ReadLine();
            int partidies = int.Parse(Console.ReadLine());
            double price = 0;

            switch (colour)
            {
                case "Red":
                    if (size == "Large")
                    {
                        price = partidies * 16;
                    }else if (size == "Medium")
                    {
                        price = partidies * 13;
                    }else if(size == "Small")
                    {
                        price = partidies * 9;
                    }
                    break;
                case "Green":
                    if (size == "Large")
                    {
                        price = partidies * 12;
                    }
                    else if (size == "Medium")
                    {
                        price = partidies * 9;
                    }
                    else if (size == "Small")
                    {
                        price = partidies * 8;
                    }
                    break;
                case "Yellow":
                    if (size == "Large")
                    {
                        price = partidies * 9;
                    }
                    else if (size == "Medium")
                    {
                        price = partidies * 7;
                    }
                    else if (size == "Small")
                    {
                        price = partidies * 5;
                    }
                    break;
            }
            Console.WriteLine($"{(price - (price * 0.35)):f2} leva.");
        }
    }
}
