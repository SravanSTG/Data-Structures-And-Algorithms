using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    class Node
    {
        public string data;
        public Node next;

        public Node(string value)
        {
            data = value;
            next = null;
        }
    }

    class Queue
    {
        private Node first;
        private Node last;
        private int length;

        public void Enqueue(string value)
        {
            Node newNode = new Node(value);
            length++;

            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }

        public void Dequeue()
        {
            if (first == null)
                Console.WriteLine("Queue is empty");
            else
            {
                Node temp = first;
                first = first.next;
                temp.next = null;
                length--;
            }
        }

        public void Peek()
        {
            if (first == null)
                Console.WriteLine("Queue is empty");
            else
                Console.WriteLine("The top most element is " + first.data);
        }

        public void PrintQueue()
        {
            Node current = first;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine("The length of the queue is " + length);
        }
    }

    class Program
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Peek();
            queue.Enqueue("Drac");
            queue.Enqueue("Mavis");
            queue.Enqueue("Johnny");
            queue.Enqueue("Dennis");
            queue.PrintQueue();
            queue.Peek();
            queue.Dequeue();
            queue.Dequeue();
            queue.Peek();
            queue.PrintQueue();

            Console.Read();
        }
    }
}
