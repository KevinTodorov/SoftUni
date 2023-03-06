using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            double tickets = 0;
            //int freeSpace = int.Parse(Console.ReadLine());
            //string type = Console.ReadLine();
            //double filmPercent = 0;
            int studentTickets = 0;
            int kidTickets = 0;
            int standartTickets = 0;
            //int allTickets = 0;

            while (film != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());
                double allTickets = 0;
                //double standartCounter = 0;
                //double studentCounter = 0;
                //double kidCounter = 0;
                //int boughtTickets = 0;

                while (allTickets <  freeSpace)
                {
                   string type = Console.ReadLine();
                   if(type == "End")
                    {
                        break;
                    }
                    switch (type)
                    {
                        case "student":
                            studentTickets++;
                           
                            break;
                        case "kid":
                            kidTickets++;
                            
                           break;
                        case "standard":
                            standartTickets++;
                            
                            break;
                    }
                    allTickets++;
                }

                tickets += allTickets;
                Console.WriteLine($"{film} - {(allTickets / freeSpace * 100):f2}% full.");
                film = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {tickets}");
            double students = (studentTickets / tickets) * 100;
            double standard = (standartTickets / tickets) * 100;
            double kids = (kidTickets / tickets) * 100;
            Console.WriteLine($"{students:f2}% student tickets.");
            Console.WriteLine($"{standard:f2}% standard tickets.");
            Console.WriteLine($"{kids:f2}% kids tickets.");


        }
    }
}
