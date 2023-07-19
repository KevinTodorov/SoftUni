using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            Dictionary<string, List<string>> filters = new Dictionary<string, List<string>>();

            while (command != "Print")
            {
                string[] commandInArr = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = commandInArr[0];

                switch (action)
                {
                    case "Add filter":
                    {
                        string filter = commandInArr[1];
                        if (!filters.ContainsKey(filter))
                        {
                            filters.Add(filter, new List<string>());
                        }
                        filters[filter].Add(commandInArr[2]);
                    }
                        break;
                    case "Remove filter":
                    {
                        string element = commandInArr[2];
                        if (filters[commandInArr[1]].Contains(element))
                        {
                            filters[commandInArr[1]].Remove(element);
                        }
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            List<string> temp = new List<string>();
            foreach (var name in names)
            {
                temp.Add(name);
            }

            foreach (var name in temp)
            {
                foreach (var filter in filters)
                {
                    if (filter.Key == "Starts with")
                    {
                        Predicate<string> predicate = s => s.StartsWith(filter.Value[0]);
                        names.Remove(name);
                        filters[filter.Key].Remove(filter.Value[0]);
                    }else if (filter.Key == "Ends with")
                    {
                        Predicate<string> predicate = s => s.EndsWith(filter.Value[0]);
                        names.Remove(name);
                        filters[filter.Key].Remove(filter.Value[0]);
                    }
                    else if (filter.Key == "Length")
                    {
                        int length = int.Parse(filter.Value[0]);
                        Predicate<string> predicate = s => s.Length == length;
                        names.Remove(name);
                        filters[filter.Key].Remove(filter.Value[0]);
                    }
                    else if (filter.Key == "Contains")
                    {
                        Predicate<string> predicate = s => s.Contains(filter.Value[0]);
                        names.Remove(name);
                        filters[filter.Key].Remove(filter.Value[0]);
                    }

                    if (filters[filter.Key].Count == 0)
                    {
                        filters.Remove(filter.Key);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
