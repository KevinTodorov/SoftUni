using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] arr = new int[range];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[arr.Length - 1 - i] + " ");
            //}

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            Array.Reverse(arr);
            Console.WriteLine(String.Join(" ", arr));

        }
    }
}
