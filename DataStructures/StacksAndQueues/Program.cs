using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Using_Queues
{
    class Stack
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        public void Push(int value)
        {
            q2.Enqueue(value);
            while (q1.Count != 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            Queue<int> temp = q1;
            q1 = q2;
            q2 = temp;
        }

        public void Pop()
        {
            Console.WriteLine("Popped " + q1.Peek());
            q1.Dequeue();
        }

        public void Peek()
        {
            Console.WriteLine("The top most element is " + q1.Peek());
        }

        public void Print()
        {
            foreach(var item in q1)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(3);
            s.Push(6);
            s.Push(8);
            s.Peek();
            s.Print();
            s.Pop();
            s.Pop();
            s.Push(11);
            s.Peek();
            s.Print();

            Console.Read();
        }
    }
}
