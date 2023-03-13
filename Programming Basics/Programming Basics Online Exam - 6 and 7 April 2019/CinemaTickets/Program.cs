using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            double endCounter = 0;
            double allTicketsCounter = 0;

            double studentCounter = 0;
            double standardCounter = 0;
            double kidsCounter = 0;

            double studentCounter2 = 0;
            double standardCounter2 = 0;
            double kidsCounter2 = 0;

            while (filmName != "Finish")
            {
            int avaiblePlaces = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                endCounter = 0;
                studentCounter2 = 0;
                standardCounter2 = 0;
                kidsCounter2 = 0;

                while (type != "End")
                {
                    endCounter++;
                    allTicketsCounter++;

                    switch (type)
                    {
                        case "student":
                            studentCounter++;
                            studentCounter2++;
                            break;
                        case "standard":
                            standardCounter++;
                            standardCounter2++;
                            break;
                        case "kid":
                            kidsCounter++;
                            kidsCounter2++;
                            break;
                    }
                    if (endCounter >= avaiblePlaces)
                    {
                        break; ;
                    }
                    type = Console.ReadLine();
                }
                 double allSummed = studentCounter2 + standardCounter2 + kidsCounter2;
                Console.WriteLine($"{filmName} - {((allSummed / avaiblePlaces) * 100):f2}% full.");
                filmName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {allTicketsCounter}");
            Console.WriteLine($"{((studentCounter / allTicketsCounter) * 100):f2}% student tickets.");
            Console.WriteLine($"{((standardCounter / allTicketsCounter) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((kidsCounter / allTicketsCounter) * 100):f2}% kids tickets.");
        }
    }
}
