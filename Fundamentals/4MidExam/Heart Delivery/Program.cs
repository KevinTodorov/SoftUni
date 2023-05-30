using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            int lastPosition = 0;
            int failedHouses = 0;

                for (int i = 0; i <= houses.Count; i++)
                {
                    int lengt = 0;
                    int index = 0;
                    if (command.Length > 1)
                    {
                     lengt = int.Parse(command[1]);
                     index = lastPosition + lengt;
                    }
                    
                  if (i == index || index >= houses.Count)
                    {
                        if (index < houses.Count)
                        {
                            if (houses[index] == 0)
                            {
                                Console.WriteLine($"Place {index} already had Valentine's day.");
                                lastPosition = index;
                            }
                            else if (houses[index] - lengt <= 0)
                            {
                                Console.WriteLine($"Place {index} has Valentine's day.");
                                houses[index] -= lengt;
                                lastPosition = index;
                            }
                            else
                            {
                                houses[index] -= 2;
                                failedHouses++;
                                lastPosition = index;
                            }
                        }
                        else
                        {
                            lastPosition = 0;
                            i = 0;
                            if (houses[lastPosition] == 0)
                            {
                              Console.WriteLine($"Place {0} already had Valentine's day.");
                            }else if (houses[0] - 2 == 0)
                            {
                              Console.WriteLine($"Place {0} has Valentine's day.");
                              houses[0] -= lengt;
                              failedHouses--;
                            }
                            else
                            {
                                houses[0] -= 2;
                                failedHouses++;
                            }
                        }
                        command = Console.ReadLine().Split();

                        if (command[0] == "Love!")
                        {
                            Console.WriteLine($"Cupid's last position was {lastPosition}.");
                            if (failedHouses > 0)
                            {
                                Console.WriteLine($"Cupid has failed {failedHouses} places.");
                            }
                            else
                            {
                                Console.WriteLine("Mission was successful.");
                            }
                        }
                    }
                    else
                    {
                        failedHouses++;
                    }
                }

        }
    }
}
