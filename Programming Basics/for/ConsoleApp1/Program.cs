using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double FACEBOOK = 150.00;
            const double INSTAGRAM = 100.00;
            const double REDDIT = 50.00;

            int openedBrowsers = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openedBrowsers; i++)
            {
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        salary -= FACEBOOK;
                        break;
                    case "Instagram":
                        salary -= INSTAGRAM;
                        break;
                    case "Reddit":
                        salary -= REDDIT;
                        break;
                    default:
                        salary = salary;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    return;
                }
                
            }
            Console.WriteLine(salary);
        }
    }
}
