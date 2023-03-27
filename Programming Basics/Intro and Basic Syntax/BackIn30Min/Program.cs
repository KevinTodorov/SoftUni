using System;

namespace BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double addedMinutes = minutes + 30;

            if (addedMinutes > 60)
            {
                hour += 1;

                if (hour >= 24)
                {
                    hour = 0;
                }
                addedMinutes -= 60;
            }
            if (addedMinutes < 10)
            {
                Console.WriteLine($"{hour}:0{addedMinutes}");
                return;
            }

            Console.WriteLine($"{hour}:{addedMinutes}");
        }
    }
}
