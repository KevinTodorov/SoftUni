using System;
using System.Linq;

namespace Zigzag_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] redNumbers = new string[n];
            string[] blueNumbers = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] number1 = Console.ReadLine().Split();
                //string[] number2 = Console.ReadLine().Split();

                if (i % 2 == 0)
                {
                    redNumbers[i] = number1[0];
                    blueNumbers[i] = number1[1];
                }
                else
                {
                    redNumbers[i] = number1[1];
                    blueNumbers[i] = number1[0];
                }

            }
            foreach (var redNumber in redNumbers)
            {
                Console.Write(redNumber + " ");
            }
            Console.WriteLine();
            foreach (var blueNumber in blueNumbers)
            {
                Console.Write(blueNumber + " ");
            }
        }
    }
}
