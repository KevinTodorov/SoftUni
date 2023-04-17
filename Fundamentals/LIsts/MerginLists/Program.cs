using System;
using System.Collections.Generic;
using System.Linq;

namespace MerginLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> list2 = Console.ReadLine().Split().Select(double.Parse).ToList();

            MerginLogic(list1,list2);
        }

        static void MerginLogic(List<double> list1, List<double> list2)
        {
            List<double> mergedList = new List<double>();

            int biggestCount = 0;

            if (list1.Count > biggestCount)
            {
                biggestCount = list1.Count;
            }
            if (list2.Count > biggestCount)
            {
                biggestCount = list2.Count;
            }

            for (int i = 0; i < biggestCount; i++)
            {
                if (list1.Count - 1< i)
                {                  
                }else
                {
                    mergedList.Add(list1[i]);
                }

                if (list2.Count - 1 < i)
                {
                }
                else
                {
                    mergedList.Add(list2[i]);
                }                
            }
            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
