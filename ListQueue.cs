using System;
using System.Collections.Generic;

namespace Ufar.Homework
{
    public class Queue<T>
    {
        private List<T> items = new List<T>();

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return items[0];
        }

        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;
    }
}