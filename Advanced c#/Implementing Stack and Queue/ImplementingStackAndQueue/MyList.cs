using System;

namespace ImplementingStackAndQueue
{
    /// <summary>
    /// Creating class for our list.
    /// </summary>
    public class MyList
    {
        /// <summary>
        /// Creating field for our defaultCapacity.
        /// </summary>
        private int defaultCapacity;
        /// <summary>
        /// Creating field for our list.
        /// </summary>
        private int[] data;
        /// <summary>
        /// Creating property for our Count.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Creating property for indexes.
        /// </summary>
        /// <param name="index">This is our given index</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return this.data[index];
            }
            set
            {
                this.data[index] = value;
            }
        }
        /// <summary>
        /// Creating constructor for our List with defaultCapacity.
        /// </summary>
        public MyList() : this(4)
        {

        }
        /// <summary>
        /// Creating second constructor for our List.
        /// </summary>
        /// <param name="defaultCapacity">This is our capacity if you decide to give new capacity to the list</param>
        public MyList(int defaultCapacity)
        {
            this.defaultCapacity = defaultCapacity;
            this.data = new int[defaultCapacity];
        }
        /// <summary>
        /// This is method to add number in the end of the list.
        /// </summary>
        /// <param name="element">The number we want to add.</param>
        public void Add(int element)
        {
            if (Count == data.Length)
            {
                Resize();
            }
            this.data[this.Count] = element;
            this.Count++;
        }
        /// <summary>
        /// This is method to remove a number at specified index.
        /// </summary>
        /// <param name="index">The index you want to remove number at.</param>
        /// <returns></returns>
        public int RemoveAt(int index)
        {
            int num = this.data[index];
            if (IndexValidation(index))
            {
                for (int i = index + 1; i < this.Count; i++)
                {
                    this.data[i - 1] = this.data[i];
                }
                this.Count--;
            }
            else Console.WriteLine("Invalid index.");
            return num;
        }
        /// <summary>
        /// This is a method to check if the list contains the given number in it.
        /// </summary>
        /// <param name="element">The given number.</param>
        /// <returns></returns>
        public bool Contains(int element)
        {
            foreach (var number in data)
            {
                if (number == element)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// This is a method to swap two numbers in the list.
        /// </summary>
        /// <param name="firstIndex">The index of the first number.</param>
        /// <param name="secondIndex">The index of the second number.</param>
        public void Swap(int firstIndex, int secondIndex)
        {
            if (IndexValidation(firstIndex) && IndexValidation(secondIndex))
            {
                int temp = data[firstIndex];
                data[firstIndex] = data[secondIndex];
                data[secondIndex] = temp;
            }
            else Console.WriteLine("Invalid index.");
        }
        /// <summary>
        /// This is method to check if the given index in the method is valid or not.
        /// </summary>
        /// <param name="index">Given index.</param>
        /// <returns></returns>
        private bool IndexValidation(int index)
        {
            if (index >= 0 && index < Count)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// This method is to resize the list so that we can add the number we want if our list has reached its limit.
        /// </summary>
        private void Resize()
        {
            int newDataSize = this.data.Length + 1;
            int[] newData = new int[newDataSize];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = data[i];
            }

            this.data = newData;
        }
    }
}
