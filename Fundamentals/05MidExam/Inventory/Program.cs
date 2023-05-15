using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            string[] command = Console.ReadLine().Split(" - ");

            while (true)
            {
                string help = command[0];

                if (help == "Craft!")
                {
                    break;
                }
                string item = command[1];

                if (help == "Collect")
                {
                    bool flag = false;
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (item == input[i])
                        {
                            flag = true;
                        }                       
                    }
                    if (!flag)
                    {
                        input.Add(item);
                    }
                }
                else if (help == "Drop")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (item == input[i])
                        {
                            input.RemoveAt(i);
                        }
                    }
                }
                else if (help == "Combine Items")
                {
                    string[] helpCombine = command[1].Split(":");
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (helpCombine[0] == input[i])
                        {
                            input.Insert(i + 1, helpCombine[1]);
                        }
                    }
                }
                else if (help == "Renew")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (item == input[i])
                        {
                            input.Add(item);
                            input.RemoveAt(i);
                        }
                    }
                }
                command = Console.ReadLine().Split(" - ");
            }
            Console.Write(string.Join(", ", input));
        }
    }
}
