namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.linked list
            //LinkedList<int> myList = new LinkedList<int>();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);

            //Console.WriteLine("Linked List:");
            //myList.Print();

            //Console.WriteLine("Contains 2: " + myList.Contains(2));
            //Console.WriteLine("Remove 2:");
            //myList.Remove(2);
            //myList.Print();

            //Console.WriteLine("Contains 2: " + myList.Contains(2));

            //2.stack
            //CustomStack<int> stack = new CustomStack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine("Stack Count: " + stack.Count);

            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Pop: " + stack.Pop());

            //Console.WriteLine("Peek: " + stack.Peek());

            //Console.WriteLine("Is Empty? " + stack.IsEmpty());

            //stack.Clear();

            //Console.WriteLine("Is Empty? " + stack.IsEmpty());

            
            //3.queue
            //CustomQueue<int> queue = new CustomQueue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine("Queue Count: " + queue.Count);

            //Console.WriteLine("Dequeue: " + queue.Dequeue());
            //Console.WriteLine("Dequeue: " + queue.Dequeue());

            //Console.WriteLine("Peek: " + queue.Peek());

            //Console.WriteLine("Is Empty? " + queue.IsEmpty());

            //queue.Clear();

            //Console.WriteLine("Is Empty? " + queue.IsEmpty());          

            
            //5.CRUD operation in stack
            //Stack<string> stack = new Stack<string>();

            // Create: Push elements onto the stack
            //stack.Push("Apple");
            //stack.Push("Banana");
            //stack.Push("Cherry");

            // Read       

            //foreach (string element in stack)
            //{
            //    Console.WriteLine(element);
            //}

            // Update
            //stack.Push("Mango");            

            //foreach (string element in stack)
            //{
            //    Console.WriteLine(element);
            //}

            //Delete
            //stack.Pop();
            //foreach (string element in stack)
            //{
            //    Console.WriteLine(element);
            //}


            //6.CRUD operation in stack
            Queue<string> queue = new Queue<string>();

            // Create
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            //Read
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Update
            queue.Enqueue("Mango");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Delete
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}