﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Custom_Doubly_Linked_List
{
    /// <summary>
    /// Creating Class For the List Actions.
    /// </summary>
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Creating property for Head.
        /// </summary>
        public Node<T> Head { get; set; }
        /// <summary>
        /// Creating property for Tail.
        /// </summary>
        public Node<T> Tail { get; set; }
        /// <summary>
        /// Creating property For Count.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Creating default constructor.
        /// </summary>
        public DoublyLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        /// <summary>
        /// Creating constructor with one parameter in it.
        /// </summary>
        /// <param Value="value">This is for the Node Value</param>
        public DoublyLinkedList(T value) : this()
        {
            Node<T> newNode = new Node<T>()
            {
                Value = value,
                Next = null,
                Previous = null
            };
            Count++;
            Head = Tail = newNode;
        }
        /// <summary>
        /// Creating constructor with IEnumerable in it.
        /// This constructor is going to put data in our nodes and create our nodes at all.
        /// </summary>
        /// <param Name="list">Creating new list or so called list</param>
        public DoublyLinkedList(IEnumerable<T> list) : this(list.First())
        {
            bool isFirst = true;

            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    Node<T> newNode = new Node<T>()
                    {
                        Value = item,
                        Previous = Tail,
                        Next = null
                    };
                    Tail.Next = newNode;
                    Tail = newNode;
                    Count++;
                }
            }
        }
        /// <summary>
        /// This is a method to add new Head.
        /// </summary>
        /// <param name="element">this element is the value of the Node</param>
        public void AddFirst(T element)
        {
            Node<T> newNode = new Node<T>()
            {
                Value = element,
                Next = null,
                Previous = null
            };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            Count++;
        }
        /// <summary>
        /// Creating method to add new Tail.
        /// </summary>
        /// <param name="element">This element is the value of the Node</param>
        public void AddLast(T element)
        {
            Node<T> newNode = new Node<T>()
            {
                Value = element,
                Next = null,Previous = null
            };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            Count++;
        }
        /// <summary>
        /// This is method to remove the Head.
        /// </summary>
        /// <returns>The value of the removed Head.</returns>
        public T RemoveFirst()
        {
            T returned;
            if (Count > 0)
            {
                returned = Head.Value;

                if (Head.Next == null)
                {
                    Tail = null;
                }
                else
                {
                    Head.Next.Previous = null;
                }
                Head = Head.Next;
                Count--;
                return returned;
            }
            throw new IndexOutOfRangeException("Empty List");
        }
        /// <summary>
        /// This method is to remove the Tail.
        /// </summary>
        /// <returns>The value of the Tail.</returns>
        public T RemoveLast()
        {
            T returned;
            if (Count > 0)
            {
                returned = Tail.Value;

                if (Tail.Previous == null)
                {
                    Head = null;
                }
                else
                {
                    Tail.Previous.Next = null;
                }
                Tail = Tail.Previous;
                Count--;
                return returned;
            }
            throw new IndexOutOfRangeException("Empty List");
        }
       
        //public void ForEach(Action<T> action)
        //{
        //    Node<T> currentNode = Head;

        //    while (currentNode != null)
        //    {
        //        action(currentNode.Value);
        //        currentNode = currentNode.Next;
        //    }
        //}
        /// <summary>
        /// This method returns and Array with every Node value in it.
        /// </summary>
        /// <returns>Array</returns>
        public T[] ToArray()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty List");
            }

            T[] elements = new T[Count];
            Node<T> currentNode = Head;
            int index = 0;
            while (currentNode != null)
            {
                elements[index] = currentNode.Value;
                index++;
                currentNode = currentNode.Next;
            }
            return elements;
        }
        /// <summary>
        /// Here we made our List allowed to be ForEached because of IEnumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            T[] elements = new T[Count];
            Node<T> currentNode = Head;
            int index = 0;
            while (currentNode != null)
            {
                elements[index] = currentNode.Value;
                index++;
                currentNode = currentNode.Next;
            }

            foreach (T element in elements)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
