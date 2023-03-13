using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string item = Console.ReadLine();

            int filmTicketCounter = 0;
            int otherThings = 0;

            int sum = 0;
            int price = 0;

            while (item != "End")
            {
                int size = item.Length;

                if (size > 8)
                {
                    char symbolOne = item[0];
                    char symbolTwo = item[1];
                    int one = symbolOne;
                    int two = symbolTwo;
                    price = one + two;
                    if (price > voucher)
                    {
                        break;
                    }
                    voucher -= price;
                    filmTicketCounter++;


                }else if (size <= 8)
                {
                    char symbol = item[0];
                    int n = symbol;
                    if (n > voucher)
                    {
                        break;
                    }
                    voucher -= n;
                    otherThings++;
                }
                item = Console.ReadLine();
            }
            Console.WriteLine(filmTicketCounter);
            Console.WriteLine(otherThings);
        }
    }
}
