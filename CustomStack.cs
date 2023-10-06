using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CustomStack<T>
    {
        private List<T> items;

        public CustomStack()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
            }

            int lastIndex = items.Count - 1;
            T poppedItem = items[lastIndex];
            items.RemoveAt(lastIndex);

            return poppedItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
            }

            return items[items.Count - 1];
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
