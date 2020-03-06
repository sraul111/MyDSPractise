using System;

namespace BinaryTree
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int data)
        {
            key = data;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.root = new Node(1);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(3);
         
            binaryTree.root.left.left = new Node(4);
        }
    }
}