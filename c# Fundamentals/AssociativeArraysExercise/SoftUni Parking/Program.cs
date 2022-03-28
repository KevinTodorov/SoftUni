using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registered = new Dictionary<string, string>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string username = string.Empty;
                string plate = String.Empty;
                if (input.Length == 3)
                {
                     username = input[1];
                     plate = input[2];
                }
                else
                {
                    username = input[1];
                }

                if (input[0] == "unregister")
                {
                    if (registered.ContainsKey(username))
                    {
                        if (input[0] == "unregister")
                        {
                            registered.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                    }else Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    if(!registered.ContainsKey(username))
                    {
                        registered.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with " +
                                          $"plate number {registered[username]}");
                    }
                }

            }

            foreach (var item in registered)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
