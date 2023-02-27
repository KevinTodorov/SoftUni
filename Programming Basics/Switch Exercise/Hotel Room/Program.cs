using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double Sprice = 0;
            double Aprice = 0;
            double discount = 0;
            double discount1 = 0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    Sprice = nights * 50;
                    discount = Sprice * 0.05;
                    Sprice -= discount;
                    Aprice = nights * 65;
                }
                else if (nights > 14)
                {
                    Sprice = nights * 50;
                    discount = Sprice * 0.3;
                    Sprice -= discount;
                    Aprice = nights * 65;
                    discount = Aprice * 0.1;
                    Aprice -= discount;
                }
                else if (nights < 7)
                {
                    Sprice = nights * 50; Aprice = nights * 65;
                }
                
            }if(month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    Sprice = nights * 75.20;
                    discount = Sprice * 0.2;
                    Sprice -= discount;
                    Aprice = nights * 68.70;
                    discount = Aprice * 0.1;
                    Aprice -= discount;
                }
                else if (nights <= 14)
                {
                    Sprice = nights * 75.20;
                    Aprice = nights * 68.70;
                }
            }if(month == "July" || month == "August")
            {
                if(nights > 14)
                {
                    Sprice = nights * 76;
                    Aprice = nights * 77;
                    discount = Aprice * 0.1;
                    Aprice -= discount;
                }else if (nights <= 14)
                {
                    Sprice = nights * 76;
                    Aprice = nights * 77;
                }
               
            }
            Console.WriteLine($"Apartment: {Aprice:f2} lv.");
            Console.WriteLine($"Studio: {Sprice:f2} lv.");
        }
    }
}
