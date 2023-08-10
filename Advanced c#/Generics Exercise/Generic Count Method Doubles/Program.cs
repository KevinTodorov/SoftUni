using System;
using System.Collections.Generic;

namespace Generic_Count_Method_Doubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < lines; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            double number = double.Parse(Console.ReadLine());
            var box = new Box<double>(list);
            var count = box.CountOfGreaterElements(list, number);
            Console.WriteLine(count);
        }
    }
}
