using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
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

        public void Remove(int value)
        {
            if (root == null)
            {
                Console.WriteLine("Tree does not exist");
            }
            else
            {
                Node current = root;
                Node parent = null;

                while (current != null)
                {
                    if (value < current.data)
                    {
                        parent = current;
                        current = current.left;
                    }
                    else if (value > current.data)
                    {
                        parent = current;
                        current = current.right;
                    }
                    else
                    {
                        //Found the node, let's delete it

                        //Case 1: No children or leaf node
                        if (current.left == null && current.right == null)
                        {
                            if (current == root)
                            {
                                root = null;
                            }
                            else
                            {
                                //If the left node of the parent contains the value(or is our current node), then set it to null,
                                //else set the right node to null
                                if (parent.left == current)
                                    parent.left = null;
                                else
                                    parent.right = null;
                            }
                            return;
                        }
                        //Case 2: One child
                        else if (current.left == null || current.right == null)
                        {
                            //Store the child in another temp node
                            Node child = current.left != null ? current.left : current.right;

                            if (current == root)
                            {
                                root = child;
                            }
                            else
                            {
                                //Connect the parent node to the child node
                                if (parent.left == current)
                                    parent.left = child;
                                else
                                    parent.right = child;
                            }
                            return;
                        }
                        //Case 3: Two children
                        else if (current.left != null && current.right != null)
                        {
                            //Find the minimum value in the right sub-tree
                            Node successor = GetSuccessor(current.right);
                            //Store successor value
                            int temp = successor.data;
                            //Recursively delete the successor
                            Remove(successor.data);
                            //Copy the value of the successor to the current node;
                            current.data = temp;

                            return;
                        }
                    }
                }

                if (current == null)
                    Console.WriteLine("Node does not exist");
            }
        }

        public Node GetSuccessor(Node node)
        {
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
        }
        
        public void PrintLeafNodes(Node root)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                Console.WriteLine(root.data);
                return;
            }

            if (root.left != null)
            {
                PrintLeafNodes(root.left);
            }

            if (root.right != null)
            {
                PrintLeafNodes(root.right);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(22);
            bst.Insert(10);
            bst.Insert(17);
            bst.Insert(48);
            bst.Insert(76);
            bst.Insert(33);
            bst.Insert(69);
            bst.Lookup(17);
            bst.Lookup(122);
            bst.Remove(90);
            bst.Remove(48);
            bst.Remove(10);
            bst.PrintLeafNodes(bst.root);

            Console.Read();
        }
    }
}
