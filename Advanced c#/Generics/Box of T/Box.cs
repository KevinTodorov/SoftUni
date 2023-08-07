using System.Collections.Generic;
using System.Linq;

namespace Box_of_T
{
    public class Box<T>
    {
        private readonly List<T> list;

        public int Count
        {
            get => list.Count;
        }

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T number = list.LastOrDefault();
            list.Remove(number);
            return number;
        }
    }
}
