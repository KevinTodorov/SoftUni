using System;
using System.Linq;

namespace CondenceArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
          
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int b = 0; b < arr.Length - 1; b++)
                {
                    arr[b] = arr[b] + arr[b + 1];
                }
                
            }
            Console.WriteLine(arr[0]);
        }
    }
}
