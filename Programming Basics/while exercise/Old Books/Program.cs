using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string book = Console.ReadLine();
            int checkedBooks = 0;
            while(book != bookName)
            {
                if(book == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\r\nYou checked {checkedBooks} books.");
                    return;
                }
                checkedBooks++;
                book = Console.ReadLine();
            }
            Console.WriteLine($"You checked {checkedBooks} books and found it.");
        }
    }
}
