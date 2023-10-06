using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CustomQueue<T>
    {
        private List<T> items;

        public CustomQueue()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }

            T dequeuedItem = items[0];
            items.RemoveAt(0);

            return dequeuedItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }

            return items[0];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
