using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] array = command.Split();

                switch (array[0])
                {
                    case "Urgent":
                        UrgentMethod(shoppingList, array[1]);
                        break;
                    case "Unnecessary":
                        UnnecessaryMethod(shoppingList, array[1]);
                        break;
                    case "Correct":
                        CorrectMethod(shoppingList, array[1], array[2]);
                        break;
                    case "Rearrange":
                        RearrangeMethod(shoppingList, array[1]);
                        break;;
                }
                command = Console.ReadLine();
            }

            Console.Write(string.Join(", ", shoppingList));
        }

        private static void UrgentMethod(List<string> shoppingList, string item)
        {
            bool flag = false;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (item == shoppingList[i])
                {
                    flag = true;
                }
            }

            if (!flag)
            {           
                shoppingList.Insert(0, item);
            }
        }

        private static void UnnecessaryMethod(List<string> shoppingList, string item)
        {
            bool flag = false;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (item == shoppingList[i])
                {
                    flag = true;
                }
            }

            if (flag)
            {
                shoppingList.Remove(item);
            }
        }

        private static void CorrectMethod(List<string> shoppingList, string oldItem, string newItem)
        {
            bool flag = false;
            int index = 0;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (oldItem == shoppingList[i])
                {
                    flag = true;
                    index = i;
                }
            }

            if (flag)
            {
                shoppingList.Insert(index, newItem);
                shoppingList.RemoveAt(index + 1);
            }
        }

        private static void RearrangeMethod(List<string> shoppingList, string item)
        {
            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (item == shoppingList[i])
                {
                    shoppingList.RemoveAt(i);
                    shoppingList.Add(item);
                }
            }
        }
    }
}
