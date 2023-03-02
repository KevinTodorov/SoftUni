using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTARGRAM = 100;
            const int REDDIT = 50;

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int lostSalary = 0;

            for(int i = 1; i <= tabs; i++)
            {
                string site = Console.ReadLine();
                if(salary <= 0 )
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                if(site == "Facebook")
                {
                    lostSalary += FACEBOOK;
                    salary -= FACEBOOK;
                }else if(site == "Instagram")
                {
                    lostSalary += INSTARGRAM;
                    salary -= INSTARGRAM;
                }else if(site == "Reddit")
                {
                    lostSalary += REDDIT;
                    salary -= REDDIT;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
