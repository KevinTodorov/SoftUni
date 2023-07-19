using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandInArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandInArray[0];

                switch (action)
                {
                    case "Double":
                    {
                        string criteria = commandInArray[1];
                        if (criteria == "StartsWith")
                        {
                            string filter = commandInArray[2];
                            Func<string, bool> func = x => x.StartsWith(filter);
                            var filteredNames = names.Where(func).ToList();

                            names.InsertRange(0, filteredNames);
                        }

                        if (criteria == "EndsWith")
                        {
                            string filter = commandInArray[2];
                            Func<string, bool> func = x => x.EndsWith(filter);
                            var filteredNames = names.Where(func).ToList();

                            names.InsertRange(0, filteredNames);
                        }

                        if (criteria == "Length")
                        {
                            int filter = int.Parse(commandInArray[2]);
                            Func<string, bool> func = name => name.Length == filter;
                            var filteredNames = names.Where(func).ToList();

                            names.InsertRange(0, filteredNames);
                        }
                    }
                        break;
                    case "Remove":
                    {
                        string criteria = commandInArray[1];
                        if (criteria == "StartsWith")
                        {
                            string filter = commandInArray[2];
                            Predicate<string> predicate = s => s.StartsWith(filter);

                            names.RemoveAll(predicate);
                        }

                        if (criteria == "EndsWith")
                        {
                            string filter = commandInArray[2];
                            Predicate<string> predicate = s => s.EndsWith(filter);

                            names.RemoveAll(predicate);
                        }

                        if (criteria == "Length")
                        {
                            int filter = int.Parse(commandInArray[2]);
                            Predicate<string> predicate = name => name.Length == filter;

                            names.RemoveAll(predicate);
                        }
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }else Console.WriteLine("Nobody is going to the party!");
        }
    }
}
