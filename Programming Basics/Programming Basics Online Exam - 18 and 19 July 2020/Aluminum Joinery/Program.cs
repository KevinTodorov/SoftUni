using System;

namespace Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int windows = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string deliveryOrNot = Console.ReadLine();
            double sum = 0;

            if (windows < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            switch (type)
            {
                case "90X130":
                    sum = 110 * windows;
                    if (windows > 30 && windows < 60)
                    {
                        sum -= sum * 0.05;
                    }else if(windows > 60)
                    {
                        sum -= sum * 0.08;
                    }
                    if(deliveryOrNot == "With delivery")
                    {
                        sum += 60;
                    }
                    if (windows > 99)
                    {
                        sum -= sum * 0.04;
                    }
                    break;
                case "100X150":
                    sum = 140 * windows;
                    if (windows > 40 && windows < 80)
                    {
                        sum -= sum * 0.06;
                    }
                    else if (windows > 80)
                    {
                        sum -= sum * 0.1;
                    }
                    if (deliveryOrNot == "With delivery")
                    {
                        sum += 60;
                    }
                    if (windows > 99)
                    {
                        sum -= sum * 0.04;
                    }
                    break;
                case "130X180":
                    sum = 190 * windows;
                    if (windows > 20 && windows < 50)
                    {
                        sum -= sum * 0.07;
                    }
                    else if (windows > 50)
                    {
                        sum -= sum * 0.12;
                    }
                    if (deliveryOrNot == "With delivery")
                    {
                        sum += 60;
                    }
                    if (windows > 99)
                    {
                        sum -= sum * 0.04;
                    }
                    break;
                case "200X300":
                    sum = 250 * windows;
                    if (windows > 25 && windows < 50)
                    {
                        sum -= sum * 0.09;
                    }
                    else if (windows > 50)
                    {
                        sum -= sum * 0.14;
                    }
                    if (deliveryOrNot == "With delivery")
                    {
                        sum += 60;
                    }
                    if (windows > 99)
                    {
                        sum -= sum * 0.04;
                    }
                    break;
            }
            
            Console.WriteLine($"{sum:f2} BGN");
        }
    }
}
