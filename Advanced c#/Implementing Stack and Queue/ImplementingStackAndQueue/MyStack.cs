using System;

namespace ImplementingStackAndQueue
{
    /// <summary>
    /// Creating our Stack class.
    /// </summary>
    public class MyStack
    {
        /// <summary>
        /// Making field for our stack.
        /// </summary>
        private int[] items;
        /// <summary>
        /// Making field for our constant capacity.
        /// </summary>
        private const int INITIAL_CAPACITY = 4;
        /// <summary>
        /// Creating property for our count.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Creating constructor for our stack, where we set default data.
        /// </summary>
        public MyStack()
        {
            this.Count = 0;
            this.items = new int[INITIAL_CAPACITY];
        }
        /// <summary>
        /// Method for pushing elements in to the stack.
        /// </summary>
        /// <param name="element">Our element that we want to push</param>
        public void Push(int element)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[this.Count] = element;
            this.Count++;
        }
        /// <summary>
        /// Method to pop our element on the top of the stack.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Count > 0)
            {
                int number = this.items[this.Count - 1];
                this.items[this.Count - 1] = 0;
                this.Count--;
                return number;
            }

            throw new IndexOutOfRangeException("Empty Stack");
        }
        /// <summary>
        /// Method to peek which is the element on top of our stack.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (Count > 0)
            {
                int number = this.items[this.Count - 1];
                return number;
            }

            throw new IndexOutOfRangeException("Empty Stack");
        }
        /// <summary>
        /// Method to go through each element in the stack
        /// </summary>
        /// <param name="action">How we want to print on the console</param>
        public void ForEach(Action<int> action)
        {
            foreach (var number in items)
            {
                action(number);
            }
        }
        /// <summary>
        /// Method to resize our stack if we want to add element but we have reached our stack full size.
        /// </summary>
        private void Resize()
        {
            int newDataSize = this.items.Length + 1;
            int[] newData = new int[newDataSize];
            for (int i = 0; i < this.items.Length; i++)
            {
                newData[i] = items[i];
            }

            this.items = newData;
        }
    }
}
