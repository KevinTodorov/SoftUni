using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int OtherPets = int.Parse(Console.ReadLine());

            double sum = dogs * 2.50 + OtherPets * 4;
            Console.WriteLine(sum + " lv.");
        }
    }
}
