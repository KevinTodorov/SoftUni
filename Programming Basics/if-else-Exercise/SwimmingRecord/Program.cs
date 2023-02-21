using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        
        {

            double seconds = double.Parse(Console.ReadLine());
            double meteres = int.Parse(Console.ReadLine());
            double oneMeter = double.Parse(Console.ReadLine());

            double swimming = meteres * oneMeter;
            double slowing = 0; ;

            

            if(meteres >= 15.0)
            {
                slowing = Math.Floor(meteres / 15) * 12.5;
               
                
            }
            double sum = swimming + slowing;

            if (seconds < sum)
            {
                Console.WriteLine($"No, he failed! He was {(sum - seconds):f2} seconds slower.");
            }else if (seconds > sum)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sum:f2} seconds.");
            }
        }
    }
}
