using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace BTInOrderTraversalWithoutRecursion
{
    public class Node
    {
        public Node left, right;
        public int key;
        public Node(int data)
        {
            key = data;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root { get; private set; }

        public void AddRoot(int data)
        {
            Root = new Node(data);
        }

        public BinaryTree()
        {
            Root = null;
        }
    }

    public class BinaryTraversal
    {
        public void InOrderTraversalWithoutRecursion(Node root)
        {
            if (root == null)
            {
                return;
            }
            Stack<Node> stack = new Stack<Node>();
            Node current = root;

            while (current != null || stack.Count > 0)
            {
                // reach to the left most Node of current Node 
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                Console.Write(current.key + "\n");

                current = current.right;
            }

        }

        public void InOrderTraversalWithoutRecursionPractise(Node root)
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();
            Node current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                Console.Write(current.key + "\n");

                current = current.right;
            }

        }

        public void MorrisTravel(Node root)
        {
            Node current, pre;
            if (root == null)
                return;
            current = root;
           // int n = 0;
            while (current != null)
            {
               // n = n + 1;
                if (current.left == null)
                {
                  Console.Write(current.key + " " );
                 current = current.right;
                }
                else
                {
                    //Find the inorder predecessor of current
                    pre = current.left;
                    while (pre.right != null && pre.right != current)
                        pre = pre.right;
                    
                    //make current as right child of its inorder predecessor
                    if (pre.right==null)
                    {
                        pre.right = current;
                        current = current.left;
                    }
                    else
                    {
                        pre.right = null;
                        Console.Write(current.key + " ");
                        current = current.right;
                    }

                }
            }

           // Console.Write($"the loop run for {n} times.");

        }

        public void MorrisTravelDuplicate(Node root)
        {
            Node current, previous;
            if (root == null)
                return;
            current = root;


            while (current != null)
            {
                if (current.left == null)
                {
                    Console.Write(current.key + " ");
                    current = current.right;
                }
                else
                {
                    // find the previous of current
                    previous = current.left;
                    while (previous.right != null && previous.right != current)
                        previous = previous.right;

                    //Make current as right child of previous
                    if (previous.right == null)
                    {
                        previous.right = current;
                        current = current.left;
                    }
                    // fix the right child of previous
                    else
                    {
                        previous.right = null;
                        Console.Write(current.key + " ");
                        current = current.right;
                    }
                }
            }
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            //binaryTree.AddRoot(1);
            //binaryTree.Root.right = new Node(3);
            //binaryTree.Root.left = new Node(2);
            //binaryTree.Root.left.left = new Node(4);
            //binaryTree.Root.left.right = new Node(5);

            //binaryTree.AddRoot(4);
            //binaryTree.Root.right  = new Node(3);
            //binaryTree.Root.right.left = new Node(7);
            //binaryTree.Root.right.left.left = new Node(9);
            //binaryTree.Root.right.left.right = new Node(10);
            //binaryTree.Root.right.left.right.left = new Node(6);
            //binaryTree.Root.right.left.right.right = new Node(5);

            binaryTree.AddRoot(4);
            binaryTree.Root.right = new Node(5);
            binaryTree.Root.left = new Node(2);
            binaryTree.Root.left.left = new Node(1);
            binaryTree.Root.left.right = new Node(3);
            Console.WriteLine("Printing BinaryTree in a InOrderTraversal...\n");
            BinaryTraversal binaryTraversal = new BinaryTraversal();
            //binaryTraversal.InOrderTraversalWithoutRecursion(binaryTree.Root);
           // binaryTraversal.MorrisTravel(binaryTree.Root);
           binaryTraversal.MorrisTravelDuplicate(binaryTree.Root);
        }
    }
}
