using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int dayLostCount = 0;
            int dayWonCount = 0;
            int wons = 0;
            int looses = 0;

            double money = 0;
            double allMoney = 0;

            bool flag = false;

            for (int i = 1; i <= days; i++)
            {
                 string sport = Console.ReadLine();
                money = 0;
                dayLostCount = 0;
                dayWonCount = 0;
                while (sport != "Finish")
                {
                    string winOrLose = Console.ReadLine();

                    if (winOrLose == "win")
                    {
                        dayWonCount++;
                        wons++;
                        money += 20;
                    }else
                    {
                        dayLostCount++;
                        looses++;
                    }
                    sport = Console.ReadLine();
                }
                if (dayWonCount > dayLostCount)
                {
                    money += money * 0.1;
                }
                allMoney += money;
               
            }

            if (wons > looses)
            {
                allMoney += allMoney * 0.2;
                flag = true;
            }
            if (flag)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {allMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allMoney:f2}");
            }
        }
    }
}
