using System;

namespace Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (date)
            {
                case "21-23":
                    if (destination == "France")
                    {
                        sum = 30 * nights;
                    }else if(destination == "Italy")
                    {
                        sum = 28 * nights;
                    }else if(destination == "Germany")
                    {
                        sum = 32 * nights;
                    }
                    break;
                case "24-27":
                    if(destination == "France")
                    {
                        sum = 35 * nights;
                    }else if(destination == "Italy")
                    {
                        sum = 32 * nights;
                    }else if(destination == "Germany")
                    {
                        sum = 37 * nights;
                    }
                    break;
                case "28-31":
                    if (destination == "France")
                    {
                        sum = 40 * nights;
                    }else if (destination == "Italy")
                    {
                        sum = 39 * nights;
                    }else if(destination == "Germany")
                    {
                        sum = 43 * nights;
                    }
                    break;

            }
            Console.WriteLine($"Easter trip to {destination} : {sum:f2} leva.");

        }
    }
}
