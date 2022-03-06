using System;

namespace HairSaloon
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double sum = 0;

            while(command != "closed")
            {
                string type = Console.ReadLine();
                switch (command)
                {
                    case "haircut":
                 switch (type)
                 {
                    case "mens":
                        sum += 15;
                        break;
                    case "ladies":
                        sum += 20;
                        break;
                    case "kids":
                        sum += 10;
                        break;
                 }
                        break;

                    case "color":
                        switch (type)
                        {
                            case "touch up":
                                sum += 20;
                                break;
                            case "full color":
                                sum += 30;
                                break;
                        }
                        break;
                }
                if (sum >= target)
                {
                    Console.WriteLine($"You have reached your target for the day!\r\nEarned money: {sum}lv.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Target not reached! You need {target - sum}lv. more.\r\nEarned money: {sum}lv.");
        }
    }
}
