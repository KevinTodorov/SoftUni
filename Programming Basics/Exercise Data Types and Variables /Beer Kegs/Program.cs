using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double maxSum = double.MinValue;

            string winner = String.Empty;

            for (int i = 1; i <= lines; i++)
            {
                string name = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow((double)radius, 2) * height;

                if (volume > maxSum)
                {
                    maxSum = volume;
                    winner = name;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
