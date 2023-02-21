using System;

namespace Time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            const int addedMinutes = 15;
            minutes += addedMinutes;

            if(minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }if(hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
