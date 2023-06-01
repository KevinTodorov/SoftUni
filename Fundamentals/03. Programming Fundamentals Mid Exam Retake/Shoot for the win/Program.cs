using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            int count = 0;

            while (command != "End")
            {
                int index = int.Parse(command);
                int temp = 0;
                if (index > - 1 && index <= targets.Count - 1)
                {
                    if (targets[index] == -1) { }
                    else
                    {
                        temp = targets[index];
                        targets[index] = -1;
                    }                                    

                    for (int b = 0; b < targets.Count; b++)
                    {
                        if (targets[b] == - 1)
                        {
                            targets[b] = -1;
                        }
                        else if (targets[b] > temp)
                        {
                            targets[b] -= temp;
                        }
                        else if (targets[b] <= temp)
                        {
                            targets[b] += temp;
                        }
                    }   
                    count++;                  
                }
                command = Console.ReadLine();         
            }
        
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
       
        }
    }
