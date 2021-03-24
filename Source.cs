using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Queue<T>
    {
        LinkedList<T> list;
        int size;
        public Queue()
        {
            list = new LinkedList<T>();
            size = 0;
        }

        public void Enqueue(T item)
        {
            list.AddFirst(item);
            size++;
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                return default;
            }
            T item = list.Last.Value;
            list.RemoveLast();
            size--;
            return item;
        }

        public int Size()
        {
            return size;
        }

        public void Ring(int count)
        {
            for (int i = 0; i < count%size; i++)
            {
                T item = Dequeue();
                Enqueue(item);
            }
        }
    }
}