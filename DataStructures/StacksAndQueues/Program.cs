using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Using_Stacks
{
    class Queue
    {
        private Stack<int> inbox = new Stack<int>();
        private Stack<int> outbox = new Stack<int>();

        public void Enqueue(int value)
        {
            inbox.Push(value);
        }

        public int Dequeue()
        {
            while (inbox.Count != 0)
            {
                outbox.Push(inbox.Pop());
            }
            
            int top = outbox.Pop();
            Console.WriteLine("Dequeued " + top);

            while (outbox.Count > 0)
            {
                inbox.Push(outbox.Pop());
            }

            return top;
        }

        public int Peek()
        {
            while (inbox.Count != 0)
            {
                outbox.Push(inbox.Pop());
            }

            int top = outbox.Peek();
            Console.WriteLine("The top most element is " + outbox.Peek());

            while (outbox.Count > 0)
            {
                inbox.Push(outbox.Pop());
            }

            return top;
        }

        public void Print()
        {
            while (inbox.Count != 0)
            {
                outbox.Push(inbox.Pop());
            }

            foreach(var item in outbox)
            {
                Console.WriteLine(item);
            }

            while (outbox.Count > 0)
            {
                inbox.Push(outbox.Pop());
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(2);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(8);
            q.Enqueue(9);
            q.Print();
            q.Peek();
            q.Dequeue();
            q.Print();
            q.Enqueue(12);
            q.Dequeue();
            q.Enqueue(16);
            q.Peek();
            q.Print();

            Console.Read();
        }
    }
}
