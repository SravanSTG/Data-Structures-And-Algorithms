using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
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

        public List<int> DFSInOrder()
        {
            List<int> result = new List<int>();
            TraverseInOrder(root, result);
            return result;
        }

        public List<int> DFSPreOrder()
        {
            List<int> result = new List<int>();
            TraversePreOrder(this.root, result);
            return result;
        }

        public List<int> DFSPostOrder()
        {
            List<int> result = new List<int>();
            TraversePostOrder(this.root, result);
            return result;
        }

        public List<int> TraverseInOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                TraverseInOrder(node.left, list);
            }
            list.Add(node.data);
            if (node.right != null)
            {
                TraverseInOrder(node.right, list);
            }

            return list;
        }

        public List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.data);
            if (node.left != null)
            {
                TraversePreOrder(node.left, list);
            }

            if (node.right != null)
            {
                TraversePreOrder(node.right, list);
            }

            return list;
        }

        public List<int> TraversePostOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                TraversePostOrder(node.left, list);
            }

            if (node.right != null)
            {
                TraversePostOrder(node.right, list);
            }
            list.Add(node.data);

            return list;
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

            var InOrder = bst.DFSInOrder();
            Console.Write("InOrder: ");
            PrintList(InOrder);
            var PreOrder = bst.DFSPreOrder();
            Console.Write("PreOrder: ");
            PrintList(PreOrder);
            var PostOrder = bst.DFSPostOrder();
            Console.Write("PostOrder: ");
            PrintList(PostOrder);

            Console.Read();
        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
