using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_Integers
{
    public class Box<T>
    {
        public List<T> List { get; set; }

        public Box(List<T> list)
        {
            List = list;
        }

        public void SwapMethod(List<T> list, int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < list.Count && secondIndex >= 0 && secondIndex < list.Count)
            {
                T firstElement = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = firstElement;
                List = list;
            }
            else throw new IndexOutOfRangeException("Index is out of range");
        }

        public override string ToString()
        {
            StringBuilder sbBuilder = new StringBuilder();
            foreach (T item in List)
            {
                sbBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return sbBuilder.ToString().TrimEnd();
        }
    }
}
