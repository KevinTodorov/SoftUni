using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            //int n = int.Parse(Console.ReadLine());

            //string[] nums = word.Split(' ');

            //for (int j = 0; j < n; j++)
            //{
            //    var temp = nums[0];
            //    for (var i = 0; i < nums.Length - 1; i++)
            //    {
            //        nums[i] = nums[i + 1];
            //    }
            //    nums[nums.Length - 1] = temp;
            //}
            //Console.WriteLine("{0}", string.Join(" ", nums));


            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());


            for (int j = 0; j < rotations; j++)
            {
              int firstNumber = number[0];
              for (int i = 0; i < number.Length - 1; i++)
              {
                    number[i] = number[i + 1];
                
              }
                number[number.Length - 1] = firstNumber;
            }
            Console.Write(string.Join(" ", number));
        }
    }
}
