using System;

namespace Tuple
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] nameAndCity = Console.ReadLine().Split();
            var firstTuple = new Tuple<string, string>(nameAndCity[0], nameAndCity[1]);
            string[] nameAndBeer = Console.ReadLine().Split();
            int liters = int.Parse(nameAndBeer[1]);
            var secondTuple = new Tuple<string, int>(nameAndBeer[0], liters);
            string[] numbers = Console.ReadLine().Split();
            int firstNumber = int.Parse(numbers[0]);
            double secondNumber = double.Parse(numbers[1]);
            var thirdTuple = new Tuple<int, double>(firstNumber, secondNumber);
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
