using System;
using System.Text;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameAndCity = Console.ReadLine().Split();
            var sbBuilder = new StringBuilder();
            sbBuilder = sbBuilder.Append(nameAndCity[3] + " ");
            if (nameAndCity.Length == 5)
            {
                sbBuilder = sbBuilder.Append(nameAndCity[4]);
            }
            var town = sbBuilder.ToString();

            var firstTuple = new Threeuple<string, string, string>(nameAndCity[0] + " " + nameAndCity[1], nameAndCity[2], town);

            string[] nameAndBeer = Console.ReadLine().Split();
            int liters = int.Parse(nameAndBeer[1]);
            string status = nameAndBeer[2];
            if (status == "drunk")
            {
                status = "true";
            }
            else
            {
                status = "false";
            }
            var secondTuple = new Threeuple<string, int, string>(nameAndBeer[0], liters, status);

            string[] bank = Console.ReadLine().Split();
            double secondNumber = double.Parse(bank[1]);
            var thirdTuple = new Threeuple<string, double, string>(bank[0], secondNumber, bank[2]);

            Console.WriteLine(firstTuple);

            Console.WriteLine(secondTuple);

            Console.WriteLine(thirdTuple);
        }

    }
}
