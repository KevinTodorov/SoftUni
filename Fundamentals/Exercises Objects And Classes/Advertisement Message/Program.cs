using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.", "Such a great product.", 
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors =
            {
                "Diana", "Petya", "Stella",
                "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random rdm = new Random();

            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[rdm.Next(phrases.Length)];
                string currentEvent = events[rdm.Next(events.Length)];
                string author = authors[rdm.Next(authors.Length)];
                string city = cities[rdm.Next(cities.Length)];

                Console.WriteLine($"{phrase} {currentEvent} {author} - {city}.");
            }
        }
    }
}
