using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                double price = 0;

                Item item = new Item()
                {
                    Name = input[1],
                    Price = double.Parse(input[3])
                };

                price = double.Parse(input[3]) * double.Parse(input[2]);
                Box box = new Box()
                {
                    SerialNumber = input[0],
                    Item = input[1],
                    ItemQuantity = int.Parse(input[2]),
                    Price = price,
                    ItemPrice = double.Parse(input[3])
                };

                boxes.Add(box);
                input = Console.ReadLine().Split();
            }

            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.Price).ToList();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}\r\n" +
                                  $"-- {box.Item} - ${box.ItemPrice:f2}: {box.ItemQuantity}\r\n" +
                                  $"-- ${box.Price:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }

    class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
        public double ItemPrice { get; set; }
    }
}
