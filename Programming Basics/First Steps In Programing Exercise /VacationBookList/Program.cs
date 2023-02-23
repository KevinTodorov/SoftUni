using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPagesForBook = int.Parse(Console.ReadLine());
            int PagesForOneHour = int.Parse(Console.ReadLine());
            int NumberOfDaysForTheBook = int.Parse(Console.ReadLine());
            int NeededHoursForDay = NumberOfPagesForBook / PagesForOneHour;
            int sum = NeededHoursForDay / NumberOfDaysForTheBook;
            Console.WriteLine(sum);

        }
    }
}
