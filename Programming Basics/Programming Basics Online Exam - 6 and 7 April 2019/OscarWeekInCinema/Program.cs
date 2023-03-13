using System;

namespace OscarWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string type = Console.ReadLine();
            int boughtTickets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (filmName)
            {
                case "A Star Is Born":
                    if (type == "normal")
                    {
                        price = boughtTickets * 7.50;
                    }else if(type == "luxury")
                    {
                        price = boughtTickets * 10.50;
                    }else if(type == "ultra luxury")
                    {
                        price = boughtTickets * 13.50;
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (type == "normal")
                    {
                        price = boughtTickets * 7.35;
                    }
                    else if (type == "luxury")
                    {
                        price = boughtTickets * 9.45;
                    }
                    else if (type == "ultra luxury")
                    {
                        price = boughtTickets * 12.75;
                    }
                    break;
                case "Green Book":
                    if (type == "normal")
                    {
                        price = boughtTickets * 8.15;
                    }
                    else if (type == "luxury")
                    {
                        price = boughtTickets * 10.25;
                    }
                    else if (type == "ultra luxury")
                    {
                        price = boughtTickets * 13.25;
                    }
                    break;
                case "The Favourite":
                    if (type == "normal")
                    {
                        price = boughtTickets * 8.75;
                    }
                    else if (type == "luxury")
                    {
                        price = boughtTickets * 11.55;
                    }
                    else if (type == "ultra luxury")
                    {
                        price = boughtTickets * 13.95;
                    }
                    break;
            }
            Console.WriteLine($"{filmName} -> {price:f2} lv.");
        }
    }
}
