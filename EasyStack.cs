using System;
using System.Collections.Generic;

namespace Ufar.Homework
{
    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return items[items.Count - 1];
        }

        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;
    }
}