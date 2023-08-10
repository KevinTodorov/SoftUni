using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Count_Method_Strings
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public T Element { get; set; }
        public List<T> List { get; set; }

        public Box(List<T> list)
        {
            List = list;
        }

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountOfGreaterElements<T>(List<T> list, T readLine) where T : IComparable =>
            list.Count(word => word.CompareTo(readLine) > 0);
    }
}
