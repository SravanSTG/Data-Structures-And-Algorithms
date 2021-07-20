using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Array
{
    class Stack
    {
        private ArrayList array = new ArrayList();

        public void Peek()
        {
            if (array.Count == 0)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("The top element is " + array[array.Count - 1]);
        }

        public void Push(string value)
        {
            array.Add(value);
        }

        public void Pop()
        {
            if (array.Count == 0)
                Console.WriteLine("Stack is empty");
            else
                array.RemoveAt(array.Count - 1);
        }

        public void PrintStack()
        {
            for (int i = array.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("The length of the stack is " + array.Count);
        }
    }

    class Program
    {
        static void Main()
        {
            Stack stack_array = new Stack();
            stack_array.Peek();
            stack_array.Push("Drac");
            stack_array.Push("Mavis");
            stack_array.Push("Johnny");
            stack_array.Push("Dennis");
            stack_array.PrintStack();           
            stack_array.Pop();
            stack_array.Peek();
            stack_array.Pop();
            stack_array.PrintStack();

            Console.Read();
        }
    }
}
