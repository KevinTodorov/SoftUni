﻿namespace Array_Creator
{
    public class ArrayCreator
    {

        public static T[] Create<T>(int length, T item)
        {
            T[] arr = new T[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = item;
            }

            return arr;
        }
    }
}
