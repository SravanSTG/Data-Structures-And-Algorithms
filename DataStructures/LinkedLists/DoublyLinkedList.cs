using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedLists
{
    class Node
    {
        public int data;
        public Node next;
        public Node previous;

        public Node(int value)
        {
            data = value;
            next = null;
            previous = null;
        }
    }

    class DoublyLinkedList
    {
        private Node head;
        public int length;

        public void Prepend(int value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            newNode.previous = null;
            head = newNode;
            length++;
        }

        public void Append(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                head.next = null;
                head.previous = null;
                length++;
            }
            else
            {
                Node nodeToAdd = new Node(value);
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = nodeToAdd;
                nodeToAdd.previous = current;
                length++;
            }
        }

        public void Insert(int index, int value)
        {
            if (index == 0)
            {
                Prepend(value);
            }
            else if (index >= length)
            {
                Append(value);
            }
            else
            {
                int counter = 0;
                Node nodeToAdd = new Node(value);
                Node current = head;
                Node temp;

                while (current != null)
                {
                    if (counter == index - 1)
                    {
                        temp = current.next;
                        current.next = nodeToAdd;
                        nodeToAdd.next = temp;
                        nodeToAdd.previous = current;
                        temp.previous = nodeToAdd;
                        length++;
                        break;
                    }
                    else
                    {
                        current = current.next;
                        counter++;
                    }
                }
            }
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                Node temp = head.next;
                head.next = null;
                temp.previous = null;
                head = temp;
                length--;
            }
            else if (index >= length)
            {
                Node current = head;
                Node temp;
                while (current.next != null)
                {
                    current = current.next;
                }
                temp = current.previous;
                temp.next = null;
                current.previous = null;
                length--;
            }
            else
            {
                if (index >= length)
                    index = length - 1;

                int counter = 0;
                Node current = head;
                Node temp;
                Node following;
                length--;

                while (current != null)
                {
                    if (counter == index - 1)
                    {
                        temp = current.next;
                        following = temp.next;
                        current.next = following;
                        temp.next = null;
                        temp.previous = null;
                        following.previous = current;
                        break;
                    }
                    else
                    {
                        current = current.next;
                        counter++;
                    }
                }
            }
        }

        public void Print()
        {
            Node pointer = head;
            while (pointer != null)
            {
                Console.WriteLine(pointer.data);
                pointer = pointer.next;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.Append(3);
            dll.Append(9);
            dll.Prepend(2);
            dll.Append(4);
            dll.Insert(1, 8);
            dll.Insert(3, 12);
            dll.Remove(4);
            dll.Print();
            Console.WriteLine("Length of the doubly linked list is: " + dll.length);

            Console.Read();
        }
    }
}
