using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
        }
    }

    class BinarySearchTree
    {
        public Node root;

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    if (value < current.data)
                    {
                        //Left
                        if (current.left == null)
                        {
                            current.left = newNode;
                            return;
                        }
                        current = current.left;
                    }
                    else
                    {
                        //Right
                        if (current.right == null)
                        {
                            current.right = newNode;
                            return;
                        }
                        current = current.right;
                    }
                }
            }
        }

        public void Lookup(int value)
        {
            if (root == null)
            {
                Console.WriteLine("Tree does not exist");
            }
            else
            {
                Node current = root;
                while (current != null)
                {
                    if (value < current.data)
                    {
                        current = current.left;
                    }
                    else if (value > current.data)
                    {
                        current = current.right;
                    }
                    else if (value == current.data)
                    {
                        Console.WriteLine("Node exists");
                        break;
                    }
                }

                if (current == null)
                    Console.WriteLine("Node does not exist");
            }
        }

        public List<int> BreadthFirstSearch()
        {
            Node currentNode = root;
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.data);
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            return list;
        }

        public List<int> BreadthFirstSearchRecursive(Queue<Node> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }

            var currentNode = queue.Dequeue();
            list.Add(currentNode.data);
            if (currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }
            if (currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }

            return BreadthFirstSearchRecursive(queue, list);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(22);
            bst.Insert(10);
            bst.Insert(17);
            bst.Insert(48);
            bst.Insert(76);
            bst.Insert(33);
            bst.Insert(69);

            List<int> bfsList = bst.BreadthFirstSearch();
            foreach (var item in bfsList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(bst.root);
            List<int> bfsRecList = bst.BreadthFirstSearchRecursive(queue, list);
            foreach (var item in bfsRecList)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}
