using System;
using System.Diagnostics;

namespace BTInorderTraversalUsingThreads
{

    public class Node
    {
        public Node left, right;
        public int key;
        public bool rightThread;

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
        public Node LeftMost(Node node)
        {
            if (node == null)
                return null;

            while (node.left != null)
                node = node.left;
            
            return node;
        }
        public void ThreadedInOrderTraversal(Node root)
        {
            Node current = LeftMost(root);

            while (current != null)
            {
                Console.Write(current.key + "\t");

                //If node is a thread node, then go to inorder successor
                if (current.rightThread)
                    current = current.right;
                else
                    current = LeftMost(current.right);
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.AddRoot(6);
            binaryTree.Root.left = new Node(3);
            binaryTree.Root.left.left = new Node(1);
            binaryTree.Root.left.right = new Node(5);
            binaryTree.Root.right = new Node(8);
            binaryTree.Root.right.left = new Node(7);
            binaryTree.Root.right.right = new Node(11);
            binaryTree.Root.right.right.right = new Node(13);
            binaryTree.Root.right.right.left = new Node(9);

            BinaryTraversal binaryTraversal = new BinaryTraversal();
            binaryTraversal.ThreadedInOrderTraversal(binaryTree.Root);

        }
    }
}
