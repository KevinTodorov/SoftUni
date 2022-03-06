using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());

            double sum = km;

            for (int i = 1; i <= days; i++)
            {
                double percents = double.Parse(Console.ReadLine());

                km += km * (percents / 100);
                sum += km;
            }

            if (sum < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - sum)} more kilometers");
            }
            else if (sum >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sum - 1000)} more kilometers!");
            }
        }
    }
}
